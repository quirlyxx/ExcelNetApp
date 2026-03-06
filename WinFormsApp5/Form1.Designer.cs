namespace Server
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;

        private System.Windows.Forms.Panel pnlMain;

        private System.Windows.Forms.GroupBox grpFile;
        private System.Windows.Forms.Label lblFileLabel;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnBrowse;

        private System.Windows.Forms.GroupBox grpPort;
        private System.Windows.Forms.Label lblPortLabel;
        private System.Windows.Forms.TextBox txtPort;

        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.Label lblStatus;

        private System.Windows.Forms.GroupBox grpLog;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.Button btnClearLog;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();

            this.pnlMain = new System.Windows.Forms.Panel();

            this.grpFile = new System.Windows.Forms.GroupBox();
            this.lblFileLabel = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();

            this.grpPort = new System.Windows.Forms.GroupBox();
            this.lblPortLabel = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();

            this.btnStartStop = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();

            this.grpLog = new System.Windows.Forms.GroupBox();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.btnClearLog = new System.Windows.Forms.Button();

            this.SuspendLayout();

            this.Text = "Товарний сервер";
            this.Size = new System.Drawing.Size(700, 600);
            this.MinimumSize = new System.Drawing.Size(700, 600);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.FromArgb(245, 246, 250);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5f);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);

            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 70;
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);

            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(20, 12);
            this.lblTitle.Text = "🗄 Товарний сервер";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15f, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;

            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Location = new System.Drawing.Point(23, 42);
            this.lblSubtitle.Text = "Сервер для пошуку товарів з Excel файлу";
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(210, 235, 255);

            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblSubtitle);

            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Padding = new System.Windows.Forms.Padding(20, 15, 20, 15);

            this.grpFile.Text = " 📂 Excel файл з товарами";
            this.grpFile.Location = new System.Drawing.Point(20, 15);
            this.grpFile.Size = new System.Drawing.Size(640, 75);
            this.grpFile.Font = new System.Drawing.Font("Segoe UI", 9.5f, System.Drawing.FontStyle.Bold);
            this.grpFile.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);

            this.lblFileLabel.Text = "Шлях до файлу:";
            this.lblFileLabel.Location = new System.Drawing.Point(15, 30);
            this.lblFileLabel.AutoSize = true;
            this.lblFileLabel.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.lblFileLabel.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80);

            this.txtFilePath.Location = new System.Drawing.Point(115, 27);
            this.txtFilePath.Size = new System.Drawing.Size(400, 26);
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.BackColor = System.Drawing.Color.White;
            this.txtFilePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilePath.Font = new System.Drawing.Font("Segoe UI", 9.5f);
            this.txtFilePath.PlaceholderText = "Оберіть файл...";

            this.btnBrowse.Text = "Огляд";
            this.btnBrowse.Location = new System.Drawing.Point(525, 26);
            this.btnBrowse.Size = new System.Drawing.Size(95, 28);
            this.btnBrowse.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnBrowse.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.FlatAppearance.BorderSize = 0;
            this.btnBrowse.Font = new System.Drawing.Font("Segoe UI", 9.5f, System.Drawing.FontStyle.Bold);
            this.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);

            this.grpFile.Controls.Add(this.lblFileLabel);
            this.grpFile.Controls.Add(this.txtFilePath);
            this.grpFile.Controls.Add(this.btnBrowse);

            this.grpPort.Text = " 🔌 Налаштування підключення";
            this.grpPort.Location = new System.Drawing.Point(20, 105);
            this.grpPort.Size = new System.Drawing.Size(640, 75);
            this.grpPort.Font = new System.Drawing.Font("Segoe UI", 9.5f, System.Drawing.FontStyle.Bold);
            this.grpPort.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);

            this.lblPortLabel.Text = "Порт сервера:";
            this.lblPortLabel.Location = new System.Drawing.Point(15, 30);
            this.lblPortLabel.AutoSize = true;
            this.lblPortLabel.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.lblPortLabel.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80);

            this.txtPort.Text = "5000";
            this.txtPort.Location = new System.Drawing.Point(115, 27);
            this.txtPort.Size = new System.Drawing.Size(100, 26);
            this.txtPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPort.Font = new System.Drawing.Font("Segoe UI", 9.5f);
            this.txtPort.BackColor = System.Drawing.Color.White;

            this.grpPort.Controls.Add(this.lblPortLabel);
            this.grpPort.Controls.Add(this.txtPort);

            this.btnStartStop.Text = "▶ Запустити сервер";
            this.btnStartStop.Location = new System.Drawing.Point(20, 195);
            this.btnStartStop.Size = new System.Drawing.Size(200, 42);
            this.btnStartStop.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.btnStartStop.ForeColor = System.Drawing.Color.White;
            this.btnStartStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartStop.FlatAppearance.BorderSize = 0;
            this.btnStartStop.Font = new System.Drawing.Font("Segoe UI", 11f, System.Drawing.FontStyle.Bold);
            this.btnStartStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);

            this.lblStatus.Text = "🔴 Сервер зупинено";
            this.lblStatus.Location = new System.Drawing.Point(235, 205);
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 10f, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(192, 57, 57);

            this.grpLog.Text = " 📋 Журнал подій";
            this.grpLog.Location = new System.Drawing.Point(20, 250);
            this.grpLog.Size = new System.Drawing.Size(640, 255);
            this.grpLog.Anchor = System.Windows.Forms.AnchorStyles.Top
                                  | System.Windows.Forms.AnchorStyles.Left
                                  | System.Windows.Forms.AnchorStyles.Right
                                  | System.Windows.Forms.AnchorStyles.Bottom;
            this.grpLog.Font = new System.Drawing.Font("Segoe UI", 9.5f, System.Drawing.FontStyle.Bold);
            this.grpLog.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);

            this.rtbLog.Location = new System.Drawing.Point(10, 25);
            this.rtbLog.Size = new System.Drawing.Size(620, 185);
            this.rtbLog.Anchor = System.Windows.Forms.AnchorStyles.Top
                                    | System.Windows.Forms.AnchorStyles.Left
                                    | System.Windows.Forms.AnchorStyles.Right
                                    | System.Windows.Forms.AnchorStyles.Bottom;
            this.rtbLog.ReadOnly = true;
            this.rtbLog.BackColor = System.Drawing.Color.FromArgb(30, 39, 46);
            this.rtbLog.ForeColor = System.Drawing.Color.FromArgb(180, 220, 255);
            this.rtbLog.Font = new System.Drawing.Font("Consolas", 9.5f);
            this.rtbLog.BorderStyle = System.Windows.Forms.BorderStyle.None;

            this.btnClearLog.Text = "🗑 Очистити лог";
            this.btnClearLog.Location = new System.Drawing.Point(10, 218);
            this.btnClearLog.Size = new System.Drawing.Size(150, 30);
            this.btnClearLog.BackColor = System.Drawing.Color.FromArgb(127, 140, 141);
            this.btnClearLog.ForeColor = System.Drawing.Color.White;
            this.btnClearLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearLog.FlatAppearance.BorderSize = 0;
            this.btnClearLog.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold);
            this.btnClearLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearLog.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);

            this.grpLog.Controls.Add(this.rtbLog);
            this.grpLog.Controls.Add(this.btnClearLog);


            this.pnlMain.Controls.Add(this.grpFile);
            this.pnlMain.Controls.Add(this.grpPort);
            this.pnlMain.Controls.Add(this.btnStartStop);
            this.pnlMain.Controls.Add(this.lblStatus);
            this.pnlMain.Controls.Add(this.grpLog);


            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlHeader);

            this.ResumeLayout(false);
        }
    }
}
