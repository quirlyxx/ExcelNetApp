using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Server
{
    public partial class Form1 : Form
    {
        private TcpListener? _server;
        private Thread? _serverThread;
        private bool _isRunning = false;

        // Словник: назва товару -> (ціна, кількість)
        private Dictionary<string, (decimal Price, int Quantity)> _products =
            new Dictionary<string, (decimal, int)>(StringComparer.OrdinalIgnoreCase);

        public Form1()
        {
            InitializeComponent();
        }

        // Кнопка "Огляд" - вибір Excel файлу
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Excel файли (*.xlsx)|*.xlsx";
            dialog.Title = "Оберіть Excel файл з товарами";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = dialog.FileName;
            }
        }

        // Завантажити Excel файл у словник
        private bool LoadExcel(string path)
        {
            try
            {
                _products.Clear();
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

                using var package = new ExcelPackage(new FileInfo(path));
                var sheet = package.Workbook.Worksheets[0];

                int row = 2; // Рядок 1 - заголовок, починаємо з 2
                while (sheet.Cells[row, 1].Value != null)
                {
                    string name = sheet.Cells[row, 1].Value.ToString()!.Trim();
                    decimal price = Convert.ToDecimal(sheet.Cells[row, 2].Value);
                    int quantity = Convert.ToInt32(sheet.Cells[row, 3].Value);

                    _products[name] = (price, quantity);
                    row++;
                }

                Log($"✅ Завантажено {_products.Count} товарів з файлу");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка читання файлу:\n{ex.Message}", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Кнопка "Запустити / Зупинити"
        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (_isRunning)
                StopServer();
            else
                StartServer();
        }

        private void StartServer()
        {
            // Перевірка файлу
            if (string.IsNullOrWhiteSpace(txtFilePath.Text) || !File.Exists(txtFilePath.Text))
            {
                MessageBox.Show("Будь ласка, вкажіть правильний шлях до Excel файлу!", "Увага",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Перевірка порту
            if (!int.TryParse(txtPort.Text, out int port) || port < 1 || port > 65535)
            {
                MessageBox.Show("Вкажіть правильний порт (від 1 до 65535)!", "Увага",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Завантажити Excel
            if (!LoadExcel(txtFilePath.Text))
                return;

            try
            {
                _server = new TcpListener(IPAddress.Any, port);
                _server.Start();
                _isRunning = true;

                // Оновлення UI
                btnStartStop.Text = "⏹ Зупинити сервер";
                btnStartStop.BackColor = System.Drawing.Color.FromArgb(192, 57, 57);
                lblStatus.Text = $"🟢 Сервер працює на порту {port}";
                lblStatus.ForeColor = System.Drawing.Color.FromArgb(39, 174, 96);
                txtFilePath.Enabled = false;
                txtPort.Enabled = false;
                btnBrowse.Enabled = false;

                // Запуск потоку для прийому клієнтів
                _serverThread = new Thread(ListenForClients);
                _serverThread.IsBackground = true;
                _serverThread.Start();

                Log($"🚀 Сервер запущено | Порт: {port}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не вдалось запустити сервер:\n{ex.Message}", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StopServer()
        {
            _isRunning = false;
            _server?.Stop();

            // Оновлення UI
            btnStartStop.Text = "▶ Запустити сервер";
            btnStartStop.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            lblStatus.Text = "🔴 Сервер зупинено";
            lblStatus.ForeColor = System.Drawing.Color.FromArgb(192, 57, 57);
            txtFilePath.Enabled = true;
            txtPort.Enabled = true;
            btnBrowse.Enabled = true;

            Log("⏹ Сервер зупинено");
        }

        // Очікуємо підключення нових клієнтів
        private void ListenForClients()
        {
            while (_isRunning)
            {
                try
                {
                    TcpClient client = _server!.AcceptTcpClient();
                    string clientIp = ((IPEndPoint)client.Client.RemoteEndPoint!).Address.ToString();
                    Log($"📡 Підключився клієнт: {clientIp}");

                    // Кожен клієнт - у своєму потоці
                    Thread clientThread = new Thread(() => HandleClient(client, clientIp));
                    clientThread.IsBackground = true;
                    clientThread.Start();
                }
                catch
                {
                    // Сервер зупинено - виходимо з циклу
                }
            }
        }

        // Обробка одного клієнта
        private void HandleClient(TcpClient client, string clientIp)
        {
            try
            {
                NetworkStream stream = client.GetStream();

                // Читаємо запит від клієнта
                byte[] buffer = new byte[4096];
                int bytesRead = stream.Read(buffer, 0, buffer.Length);
                string request = Encoding.UTF8.GetString(buffer, 0, bytesRead).Trim();

                Log($"📨 Запит від {clientIp}: {request}");

                // Клієнт може надіслати кілька назв через кому або крапку з комою
                string[] names = request.Split(new char[] { ',', ';' }, StringSplitOptions.RemoveEmptyEntries);
                StringBuilder response = new StringBuilder();

                decimal totalSum = 0;

                foreach (string rawName in names)
                {
                    string name = rawName.Trim();
                    if (string.IsNullOrEmpty(name)) continue;

                    if (_products.ContainsKey(name))
                    {
                        var (price, qty) = _products[name];
                        decimal sum = price * qty;
                        totalSum += sum;

                        response.AppendLine($"✔ {name}");
                        response.AppendLine($"   Ціна: {price:F2} грн  |  Кількість: {qty} шт  |  Сума: {sum:F2} грн");
                    }
                    else
                    {
                        response.AppendLine($"✘ {name} — товар не знайдено");
                    }
                }

                if (names.Length > 1)
                    response.AppendLine($"\n💰 Загальна сума: {totalSum:F2} грн");

                // Відправляємо відповідь клієнту
                byte[] responseBytes = Encoding.UTF8.GetBytes(response.ToString());
                stream.Write(responseBytes, 0, responseBytes.Length);

                Log($"📤 Відповідь надіслана до {clientIp}");
            }
            catch (Exception ex)
            {
                Log($"⚠ Помилка з клієнтом {clientIp}: {ex.Message}");
            }
            finally
            {
                client.Close();
            }
        }

        // Кнопка "Очистити лог"
        private void btnClearLog_Click(object sender, EventArgs e)
        {
            rtbLog.Clear();
        }

        // Безпечне додавання тексту в лог (з іншого потоку)
        private void Log(string message)
        {
            if (rtbLog.InvokeRequired)
            {
                rtbLog.Invoke(new Action(() => Log(message)));
                return;
            }

            rtbLog.AppendText($"[{DateTime.Now:HH:mm:ss}] {message}{Environment.NewLine}");
            rtbLog.ScrollToCaret();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_isRunning)
                StopServer();
        }
    }
}
