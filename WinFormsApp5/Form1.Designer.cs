namespace Server
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // Контролі
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
            pnlHeader = new Panel();
            lblTitle = new Label();
            lblSubtitle = new Label();
            pnlMain = new Panel();
            grpFile = new GroupBox();
            lblFileLabel = new Label();
            txtFilePath = new TextBox();
            btnBrowse = new Button();
            grpPort = new GroupBox();
            lblPortLabel = new Label();
            txtPort = new TextBox();
            btnStartStop = new Button();
            lblStatus = new Label();
            grpLog = new GroupBox();
            rtbLog = new RichTextBox();
            btnClearLog = new Button();
            pnlHeader.SuspendLayout();
            pnlMain.SuspendLayout();
            grpFile.SuspendLayout();
            grpPort.SuspendLayout();
            grpLog.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(41, 128, 185);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(lblSubtitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new Padding(20, 0, 0, 0);
            pnlHeader.Size = new Size(684, 70);
            pnlHeader.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(215, 28);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "🗄 Товарний сервер";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 9F);
            lblSubtitle.ForeColor = Color.FromArgb(210, 235, 255);
            lblSubtitle.Location = new Point(23, 42);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(234, 15);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Сервер для пошуку товарів з Excel файлу";
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(grpFile);
            pnlMain.Controls.Add(grpPort);
            pnlMain.Controls.Add(btnStartStop);
            pnlMain.Controls.Add(lblStatus);
            pnlMain.Controls.Add(grpLog);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 70);
            pnlMain.Name = "pnlMain";
            pnlMain.Padding = new Padding(20, 15, 20, 15);
            pnlMain.Size = new Size(684, 491);
            pnlMain.TabIndex = 0;
            // 
            // grpFile
            // 
            grpFile.Controls.Add(lblFileLabel);
            grpFile.Controls.Add(txtFilePath);
            grpFile.Controls.Add(btnBrowse);
            grpFile.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            grpFile.ForeColor = Color.FromArgb(44, 62, 80);
            grpFile.Location = new Point(20, 15);
            grpFile.Name = "grpFile";
            grpFile.Size = new Size(640, 75);
            grpFile.TabIndex = 0;
            grpFile.TabStop = false;
            grpFile.Text = " 📂 Excel файл з товарами";
            // 
            // lblFileLabel
            // 
            lblFileLabel.AutoSize = true;
            lblFileLabel.Font = new Font("Segoe UI", 9F);
            lblFileLabel.ForeColor = Color.FromArgb(80, 80, 80);
            lblFileLabel.Location = new Point(15, 30);
            lblFileLabel.Name = "lblFileLabel";
            lblFileLabel.Size = new Size(94, 15);
            lblFileLabel.TabIndex = 0;
            lblFileLabel.Text = "Шлях до файлу:";
            // 
            // txtFilePath
            // 
            txtFilePath.BackColor = Color.White;
            txtFilePath.BorderStyle = BorderStyle.FixedSingle;
            txtFilePath.Font = new Font("Segoe UI", 9.5F);
            txtFilePath.Location = new Point(115, 27);
            txtFilePath.Name = "txtFilePath";
            txtFilePath.PlaceholderText = "Оберіть файл...";
            txtFilePath.ReadOnly = true;
            txtFilePath.Size = new Size(400, 24);
            txtFilePath.TabIndex = 1;
            // 
            // btnBrowse
            // 
            btnBrowse.BackColor = Color.FromArgb(52, 152, 219);
            btnBrowse.Cursor = Cursors.Hand;
            btnBrowse.FlatAppearance.BorderSize = 0;
            btnBrowse.FlatStyle = FlatStyle.Flat;
            btnBrowse.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnBrowse.ForeColor = Color.White;
            btnBrowse.Location = new Point(525, 26);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(95, 28);
            btnBrowse.TabIndex = 2;
            btnBrowse.Text = "Огляд";
            btnBrowse.UseVisualStyleBackColor = false;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // grpPort
            // 
            grpPort.Controls.Add(lblPortLabel);
            grpPort.Controls.Add(txtPort);
            grpPort.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            grpPort.ForeColor = Color.FromArgb(44, 62, 80);
            grpPort.Location = new Point(20, 105);
            grpPort.Name = "grpPort";
            grpPort.Size = new Size(640, 75);
            grpPort.TabIndex = 1;
            grpPort.TabStop = false;
            grpPort.Text = " 🔌 Налаштування підключення";
            // 
            // lblPortLabel
            // 
            lblPortLabel.AutoSize = true;
            lblPortLabel.Font = new Font("Segoe UI", 9F);
            lblPortLabel.ForeColor = Color.FromArgb(80, 80, 80);
            lblPortLabel.Location = new Point(15, 30);
            lblPortLabel.Name = "lblPortLabel";
            lblPortLabel.Size = new Size(85, 15);
            lblPortLabel.TabIndex = 0;
            lblPortLabel.Text = "Порт сервера:";
            // 
            // txtPort
            // 
            txtPort.BackColor = Color.White;
            txtPort.BorderStyle = BorderStyle.FixedSingle;
            txtPort.Font = new Font("Segoe UI", 9.5F);
            txtPort.Location = new Point(115, 27);
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(100, 24);
            txtPort.TabIndex = 1;
            txtPort.Text = "5000";
            // 
            // btnStartStop
            // 
            btnStartStop.BackColor = Color.FromArgb(41, 128, 185);
            btnStartStop.Cursor = Cursors.Hand;
            btnStartStop.FlatAppearance.BorderSize = 0;
            btnStartStop.FlatStyle = FlatStyle.Flat;
            btnStartStop.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnStartStop.ForeColor = Color.White;
            btnStartStop.Location = new Point(20, 195);
            btnStartStop.Name = "btnStartStop";
            btnStartStop.Size = new Size(200, 42);
            btnStartStop.TabIndex = 2;
            btnStartStop.Text = "▶ Запустити сервер";
            btnStartStop.UseVisualStyleBackColor = false;
            btnStartStop.Click += btnStartStop_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblStatus.ForeColor = Color.FromArgb(192, 57, 57);
            lblStatus.Location = new Point(235, 205);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(156, 19);
            lblStatus.TabIndex = 3;
            lblStatus.Text = "🔴 Сервер зупинено";
            // 
            // grpLog
            // 
            grpLog.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpLog.Controls.Add(rtbLog);
            grpLog.Controls.Add(btnClearLog);
            grpLog.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            grpLog.ForeColor = Color.FromArgb(44, 62, 80);
            grpLog.Location = new Point(20, 250);
            grpLog.Name = "grpLog";
            grpLog.Size = new Size(641, 229);
            grpLog.TabIndex = 4;
            grpLog.TabStop = false;
            grpLog.Text = " 📋 Журнал подій";
            // 
            // rtbLog
            // 
            rtbLog.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rtbLog.BackColor = Color.FromArgb(30, 39, 46);
            rtbLog.BorderStyle = BorderStyle.None;
            rtbLog.Font = new Font("Consolas", 9.5F);
            rtbLog.ForeColor = Color.FromArgb(180, 220, 255);
            rtbLog.Location = new Point(10, 25);
            rtbLog.Name = "rtbLog";
            rtbLog.ReadOnly = true;
            rtbLog.Size = new Size(621, 159);
            rtbLog.TabIndex = 0;
            rtbLog.Text = "";
            // 
            // btnClearLog
            // 
            btnClearLog.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnClearLog.BackColor = Color.FromArgb(127, 140, 141);
            btnClearLog.Cursor = Cursors.Hand;
            btnClearLog.FlatAppearance.BorderSize = 0;
            btnClearLog.FlatStyle = FlatStyle.Flat;
            btnClearLog.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnClearLog.ForeColor = Color.White;
            btnClearLog.Location = new Point(10, 192);
            btnClearLog.Name = "btnClearLog";
            btnClearLog.Size = new Size(150, 30);
            btnClearLog.TabIndex = 1;
            btnClearLog.Text = "🗑 Очистити лог";
            btnClearLog.UseVisualStyleBackColor = false;
            btnClearLog.Click += btnClearLog_Click;
            // 
            // Form1
            // 
            BackColor = Color.FromArgb(245, 246, 250);
            ClientSize = new Size(684, 561);
            Controls.Add(pnlMain);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 9.5F);
            MinimumSize = new Size(700, 600);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Товарний сервер";
            FormClosing += Form1_FormClosing;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            grpFile.ResumeLayout(false);
            grpFile.PerformLayout();
            grpPort.ResumeLayout(false);
            grpPort.PerformLayout();
            grpLog.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}
