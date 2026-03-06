using System;
using System.Globalization;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ClientForm
{
    public partial class Form1 : Form
    {
        private bool _isConnected = false;
        public Form1()
        {
            InitializeComponent();
            UIStart();
        }
        private void UIStart()
        {
            txtServerIp.Text = "127.0.0.1";
            numPort.Minimum = 1;
            numPort.Maximum = 10000;
            numPort.Value = 888;

            btnDisconnect.Enabled = false;
            button1.Enabled = false;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string serverIp = txtServerIp.Text.Trim();
            int port = (int)numPort.Value;

            if (string.IsNullOrWhiteSpace(serverIp))
            {
                MessageBox.Show("Введіть адресу сервера.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using TcpClient client = new TcpClient();
                client.Connect(serverIp, port);

                _isConnected = true;
                txtServerIp.Enabled = false;
                numPort.Enabled = false;
                btnConnect.Enabled = false;
                btnDisconnect.Enabled = true;
                button1.Enabled = true;
                MessageBox.Show("Підключення успішне!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                _isConnected = false;
                MessageBox.Show($"Помилка підключення:\n{ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            _isConnected = false;
            txtServerIp.Enabled = true;
            btnConnect.Enabled = true;
            numPort.Enabled = true;
            btnDisconnect.Enabled = false;
            button1.Enabled = false;

            MessageBox.Show("Ви відключилися від сервера.", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            AddProduct();
        }

        private void AddProduct()
        {
            string productName = txtProductName.Text.Trim();

            if (string.IsNullOrWhiteSpace(productName))
            {
                MessageBox.Show("Введіть назву товару.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProductName.Focus();
                return;
            }

            bool exists = lstRequestItems.Items.Cast<object>().Any(x => string.Equals(x.ToString(), productName, StringComparison.OrdinalIgnoreCase));
            if (exists)
            {
                MessageBox.Show("Товар вже доданий до запиту.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProductName.Focus();
                txtProductName.Clear();
                return;
            }

            lstRequestItems.Items.Add(productName);
            txtProductName.Clear();
            txtProductName.Focus();
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (lstRequestItems.SelectedItem != null)
            {
                lstRequestItems.Items.Remove(lstRequestItems.SelectedItem);
            }
            else
            {
                MessageBox.Show("Виберіть товар для видалення.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClearItems_Click(object sender, EventArgs e)
        {
            lstRequestItems.Items.Clear();
            dataGridView1.Rows.Clear();
            txtTotalSum.Clear();
            txtProductName.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!_isConnected)
            {
                MessageBox.Show("Спочатку підключіться до сервера.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }

            if(lstRequestItems.Items.Count == 0)
            {
                MessageBox.Show("Список товарів порожній.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }

            string serverIp = txtServerIp.Text.Trim();
            int port = (int)numPort.Value;
            try
            {
                string request = string.Join(", ", lstRequestItems.Items.Cast<object>().Select(x => x.ToString()));
                using TcpClient client = new TcpClient();
                client.Connect(serverIp, port);
                using NetworkStream stream = client.GetStream();
                byte[] requestBytes = Encoding.UTF8.GetBytes(request);
                stream.Write(requestBytes, 0, requestBytes.Length);
                byte[] buffer = new byte[8192];
                int bytesRead = stream.Read(buffer, 0, buffer.Length);

                if(bytesRead <= 0)
                {
                    MessageBox.Show("Сервер не надіслав відповідь.", "Помилка",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string response = Encoding.UTF8.GetString(buffer, 0, bytesRead).Trim();
                if (string.IsNullOrWhiteSpace(response))
                {
                    MessageBox.Show("Отримано порожню відповідь від сервера.", "Помилка",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                ParseServerResponse(response);
                MessageBox.Show("Відповідь від сервера отримано.", "Успіх",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SocketException ex)
            {
                MessageBox.Show($"Помилка мережі:\n{ex.Message}", "Помилка",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка під час відправки запиту:\n{ex.Message}", "Помилка",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ParseServerResponse(string response)
        {
            dataGridView1.Rows.Clear();
            txtTotalSum.Clear();

            string[] lines = response.Split(
                new[] { "\r\n", "\n" },
                StringSplitOptions.RemoveEmptyEntries);

            string currentName = string.Empty;
            decimal totalSum = 0m;

            foreach (string raw in lines)
            {
                string line = raw.Trim();

                if (line.StartsWith("✔ "))
                {
                    currentName = line.Substring(2).Trim();
                }
                else if (line.StartsWith("Ціна:"))
                {
                    decimal price = ExtractDecimal(line, @"Ціна:\s*([\d\.,]+)");
                    int quantity = ExtractInt(line, @"Кількість:\s*(\d+)");
                    decimal sum = ExtractDecimal(line, @"Сума:\s*([\d\.,]+)");

                    dataGridView1.Rows.Add(
                        currentName,
                        price.ToString("F2"),
                        quantity.ToString(),
                        sum.ToString("F2"));
                }
                else if (line.StartsWith("✘ "))
                {
                    string notFoundName = line.Substring(2).Trim();

                    int dashIndex = notFoundName.IndexOf('—');
                    if (dashIndex >= 0)
                        notFoundName = notFoundName.Substring(0, dashIndex).Trim();

                    dataGridView1.Rows.Add(notFoundName, "-", "-", "Не знайдено");
                }
                else if (line.StartsWith("💰 Загальна сума:"))
                {
                    totalSum = ExtractDecimal(line, @"Загальна сума:\s*([\d\.,]+)");
                }
            }

            if (totalSum == 0m)
                totalSum = CalculateTotalFromGrid();

            txtTotalSum.Text = totalSum.ToString("F2");
        }

        private decimal CalculateTotalFromGrid()
        {
            decimal total = 0m;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow)
                    continue;

                object cellValue = row.Cells[3].Value;
                if (cellValue == null)
                    continue;

                string text = cellValue.ToString() ?? string.Empty;

                if (decimal.TryParse(text, NumberStyles.Any, new CultureInfo("uk-UA"), out decimal value))
                {
                    total += value;
                }
                else if (decimal.TryParse(text, NumberStyles.Any, CultureInfo.InvariantCulture, out value))
                {
                    total += value;
                }
            }

            return total;
        }

        private decimal ExtractDecimal(string input, string pattern)
        {
            Match match = Regex.Match(input, pattern);

            if (!match.Success)
                return 0m;

            string value = match.Groups[1].Value.Replace(',', '.');

            return decimal.TryParse(value, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal result)
                ? result
                : 0m;
        }

        private int ExtractInt(string input, string pattern)
        {
            Match match = Regex.Match(input, pattern);

            if (!match.Success)
                return 0;

            return int.TryParse(match.Groups[1].Value, out int result)
                ? result
                : 0;
        }
    }
}

