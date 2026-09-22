namespace Scanning_Ports
{
    partial class PortsScan
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("");
            this.label_left_up = new System.Windows.Forms.Label();
            this.label_center_up = new System.Windows.Forms.Label();
            this.label_right_up = new System.Windows.Forms.Label();
            this.textBox_host = new System.Windows.Forms.TextBox();
            this.numeric_portDown = new System.Windows.Forms.NumericUpDown();
            this.numeric_portUp = new System.Windows.Forms.NumericUpDown();
            this.button_scan = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_portDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_portUp)).BeginInit();
            this.SuspendLayout();
            // 
            // label_left_up
            // 
            this.label_left_up.AutoSize = true;
            this.label_left_up.Location = new System.Drawing.Point(40, 41);
            this.label_left_up.Name = "label_left_up";
            this.label_left_up.Size = new System.Drawing.Size(102, 25);
            this.label_left_up.TabIndex = 1;
            this.label_left_up.Text = "IP адрес:";
            // 
            // label_center_up
            // 
            this.label_center_up.AutoSize = true;
            this.label_center_up.Location = new System.Drawing.Point(367, 41);
            this.label_center_up.Name = "label_center_up";
            this.label_center_up.Size = new System.Drawing.Size(99, 25);
            this.label_center_up.TabIndex = 2;
            this.label_center_up.Text = "Порты с:";
            // 
            // label_right_up
            // 
            this.label_right_up.AutoSize = true;
            this.label_right_up.Location = new System.Drawing.Point(566, 41);
            this.label_right_up.Name = "label_right_up";
            this.label_right_up.Size = new System.Drawing.Size(42, 25);
            this.label_right_up.TabIndex = 3;
            this.label_right_up.Text = "по:";
            // 
            // textBox_host
            // 
            this.textBox_host.Location = new System.Drawing.Point(148, 41);
            this.textBox_host.Name = "textBox_host";
            this.textBox_host.Size = new System.Drawing.Size(180, 31);
            this.textBox_host.TabIndex = 4;
            // 
            // numeric_portDown
            // 
            this.numeric_portDown.Location = new System.Drawing.Point(473, 41);
            this.numeric_portDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numeric_portDown.Name = "numeric_portDown";
            this.numeric_portDown.Size = new System.Drawing.Size(85, 31);
            this.numeric_portDown.TabIndex = 5;
            // 
            // numeric_portUp
            // 
            this.numeric_portUp.Location = new System.Drawing.Point(614, 39);
            this.numeric_portUp.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numeric_portUp.Name = "numeric_portUp";
            this.numeric_portUp.Size = new System.Drawing.Size(85, 31);
            this.numeric_portUp.TabIndex = 6;
            // 
            // button_scan
            // 
            this.button_scan.Location = new System.Drawing.Point(746, 39);
            this.button_scan.Name = "button_scan";
            this.button_scan.Size = new System.Drawing.Size(174, 50);
            this.button_scan.TabIndex = 7;
            this.button_scan.Text = "Сканировать";
            this.button_scan.UseVisualStyleBackColor = true;
            this.button_scan.Click += new System.EventHandler(this.button_scan_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3});
            this.listView1.Location = new System.Drawing.Point(20, 159);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1086, 679);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Порт:";
            this.columnHeader1.Width = 294;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Открыт:";
            this.columnHeader2.Width = 130;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Закрыт:";
            this.columnHeader3.Width = 130;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(20, 869);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1086, 36);
            this.progressBar1.TabIndex = 9;
            // 
            // PortsScan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 948);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button_scan);
            this.Controls.Add(this.numeric_portUp);
            this.Controls.Add(this.numeric_portDown);
            this.Controls.Add(this.textBox_host);
            this.Controls.Add(this.label_right_up);
            this.Controls.Add(this.label_center_up);
            this.Controls.Add(this.label_left_up);
            this.Name = "PortsScan";
            this.Text = "PortsScan";
            this.Load += new System.EventHandler(this.PortsScan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numeric_portDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_portUp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_left_up;
        private System.Windows.Forms.Label label_center_up;
        private System.Windows.Forms.Label label_right_up;
        private System.Windows.Forms.TextBox textBox_host;
        private System.Windows.Forms.NumericUpDown numeric_portDown;
        private System.Windows.Forms.NumericUpDown numeric_portUp;
        private System.Windows.Forms.Button button_scan;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        public System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

