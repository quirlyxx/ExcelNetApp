using System;
using System.Drawing;
using System.Windows.Forms;

namespace ClientForm
{
    partial class Form1 : Form
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.NumericUpDown numPort;
        private System.Windows.Forms.TextBox txtServerIp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstRequestItems;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnClearItems;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SumColumn;
        private System.Windows.Forms.TextBox txtTotalSum;
        private System.Windows.Forms.Label label3;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnDisconnect = new Button();
            btnConnect = new Button();
            numPort = new NumericUpDown();
            txtServerIp = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            button1 = new Button();
            btnClearItems = new Button();
            btnRemoveItem = new Button();
            btnAddItem = new Button();
            txtProductName = new TextBox();
            lstRequestItems = new ListBox();
            label4 = new Label();
            groupBox3 = new GroupBox();
            txtTotalSum = new TextBox();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            ProductNameColumn = new DataGridViewTextBoxColumn();
            PriceColumn = new DataGridViewTextBoxColumn();
            QuantityColumn = new DataGridViewTextBoxColumn();
            SumColumn = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numPort).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLight;
            groupBox1.Controls.Add(btnDisconnect);
            groupBox1.Controls.Add(btnConnect);
            groupBox1.Controls.Add(numPort);
            groupBox1.Controls.Add(txtServerIp);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(349, 220);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Сервер";
            // 
            // btnDisconnect
            // 
            btnDisconnect.BackColor = Color.IndianRed;
            btnDisconnect.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnDisconnect.Location = new Point(179, 161);
            btnDisconnect.Name = "btnDisconnect";
            btnDisconnect.Size = new Size(150, 41);
            btnDisconnect.TabIndex = 5;
            btnDisconnect.Text = "Відключитись";
            btnDisconnect.UseVisualStyleBackColor = false;
            btnDisconnect.Click += btnDisconnect_Click;
            // 
            // btnConnect
            // 
            btnConnect.BackColor = Color.PaleGreen;
            btnConnect.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnConnect.Location = new Point(179, 114);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(150, 41);
            btnConnect.TabIndex = 4;
            btnConnect.Text = "Підключитись";
            btnConnect.UseVisualStyleBackColor = false;
            btnConnect.Click += btnConnect_Click;
            // 
            // numPort
            // 
            numPort.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            numPort.Location = new Point(179, 66);
            numPort.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            numPort.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numPort.Name = "numPort";
            numPort.Size = new Size(150, 30);
            numPort.TabIndex = 3;
            numPort.Value = new decimal(new int[] { 5000, 0, 0, 0 });
            // 
            // txtServerIp
            // 
            txtServerIp.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            txtServerIp.Location = new Point(179, 30);
            txtServerIp.Name = "txtServerIp";
            txtServerIp.Size = new Size(150, 30);
            txtServerIp.TabIndex = 2;
            txtServerIp.Text = "127.0.0.1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(6, 73);
            label2.Name = "label2";
            label2.Size = new Size(57, 23);
            label2.TabIndex = 1;
            label2.Text = "Порт:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(6, 33);
            label1.Name = "label1";
            label1.Size = new Size(148, 23);
            label1.TabIndex = 0;
            label1.Text = "Адреса сервера:";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ControlLight;
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(btnClearItems);
            groupBox2.Controls.Add(btnRemoveItem);
            groupBox2.Controls.Add(btnAddItem);
            groupBox2.Controls.Add(txtProductName);
            groupBox2.Controls.Add(lstRequestItems);
            groupBox2.Controls.Add(label4);
            groupBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBox2.Location = new Point(367, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(673, 561);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Введення товарів";
            // 
            // button1
            // 
            button1.BackColor = Color.PaleGreen;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.Location = new Point(441, 432);
            button1.Name = "button1";
            button1.Size = new Size(218, 49);
            button1.TabIndex = 6;
            button1.Text = "Надіслати запит";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnClearItems
            // 
            btnClearItems.BackColor = Color.Gray;
            btnClearItems.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnClearItems.Location = new Point(553, 386);
            btnClearItems.Name = "btnClearItems";
            btnClearItems.Size = new Size(106, 40);
            btnClearItems.TabIndex = 5;
            btnClearItems.Text = "Очистити";
            btnClearItems.UseVisualStyleBackColor = false;
            btnClearItems.Click += btnClearItems_Click;
            // 
            // btnRemoveItem
            // 
            btnRemoveItem.BackColor = Color.Gray;
            btnRemoveItem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnRemoveItem.Location = new Point(441, 386);
            btnRemoveItem.Name = "btnRemoveItem";
            btnRemoveItem.Size = new Size(106, 40);
            btnRemoveItem.TabIndex = 4;
            btnRemoveItem.Text = "Видалити";
            btnRemoveItem.UseVisualStyleBackColor = false;
            btnRemoveItem.Click += btnRemoveItem_Click;
            // 
            // btnAddItem
            // 
            btnAddItem.BackColor = Color.Gray;
            btnAddItem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnAddItem.Location = new Point(329, 386);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(106, 40);
            btnAddItem.TabIndex = 3;
            btnAddItem.Text = "Додати";
            btnAddItem.UseVisualStyleBackColor = false;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // txtProductName
            // 
            txtProductName.BackColor = SystemColors.MenuBar;
            txtProductName.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            txtProductName.Location = new Point(9, 388);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(317, 38);
            txtProductName.TabIndex = 2;
            // 
            // lstRequestItems
            // 
            lstRequestItems.BackColor = SystemColors.MenuBar;
            lstRequestItems.FormattingEnabled = true;
            lstRequestItems.ItemHeight = 23;
            lstRequestItems.Location = new Point(9, 71);
            lstRequestItems.Name = "lstRequestItems";
            lstRequestItems.Size = new Size(658, 303);
            lstRequestItems.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(6, 33);
            label4.Name = "label4";
            label4.Size = new Size(206, 23);
            label4.TabIndex = 0;
            label4.Text = "Найменування товарів:";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.ControlLight;
            groupBox3.Controls.Add(txtTotalSum);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBox3.Location = new Point(1046, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(673, 561);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Відповідь сервера";
            // 
            // txtTotalSum
            // 
            txtTotalSum.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            txtTotalSum.Location = new Point(145, 392);
            txtTotalSum.Name = "txtTotalSum";
            txtTotalSum.ReadOnly = true;
            txtTotalSum.Size = new Size(150, 30);
            txtTotalSum.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(6, 395);
            label3.Name = "label3";
            label3.Size = new Size(133, 23);
            label3.TabIndex = 1;
            label3.Text = "Загальна сума:";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.MenuBar;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ProductNameColumn, PriceColumn, QuantityColumn, SumColumn });
            dataGridView1.GridColor = SystemColors.ControlLightLight;
            dataGridView1.Location = new Point(6, 71);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(661, 303);
            dataGridView1.TabIndex = 0;
            // 
            // ProductNameColumn
            // 
            ProductNameColumn.HeaderText = "Найменування";
            ProductNameColumn.MinimumWidth = 6;
            ProductNameColumn.Name = "ProductNameColumn";
            ProductNameColumn.ReadOnly = true;
            ProductNameColumn.Resizable = DataGridViewTriState.False;
            // 
            // PriceColumn
            // 
            PriceColumn.HeaderText = "Ціна";
            PriceColumn.MinimumWidth = 6;
            PriceColumn.Name = "PriceColumn";
            PriceColumn.ReadOnly = true;
            PriceColumn.Resizable = DataGridViewTriState.False;
            // 
            // QuantityColumn
            // 
            QuantityColumn.HeaderText = "Кількість";
            QuantityColumn.MinimumWidth = 6;
            QuantityColumn.Name = "QuantityColumn";
            QuantityColumn.ReadOnly = true;
            QuantityColumn.Resizable = DataGridViewTriState.False;
            // 
            // SumColumn
            // 
            SumColumn.HeaderText = "Сума";
            SumColumn.MinimumWidth = 6;
            SumColumn.Name = "SumColumn";
            SumColumn.ReadOnly = true;
            SumColumn.Resizable = DataGridViewTriState.False;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1728, 585);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Клієнт";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numPort).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
    }
}