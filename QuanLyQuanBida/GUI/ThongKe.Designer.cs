namespace GUI
{
    partial class ThongKe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongKe));
            this.label6 = new System.Windows.Forms.Label();
            this.dtgvThongKe = new System.Windows.Forms.DataGridView();
            this.cbbMonth = new System.Windows.Forms.ComboBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThongKeThang = new System.Windows.Forms.Button();
            this.btnThongKeNam = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkOrange;
            this.label6.Location = new System.Drawing.Point(94, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(443, 50);
            this.label6.TabIndex = 28;
            this.label6.Text = "THỐNG KÊ DOANH THU";
            // 
            // dtgvThongKe
            // 
            this.dtgvThongKe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvThongKe.BackgroundColor = System.Drawing.Color.Bisque;
            this.dtgvThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvThongKe.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgvThongKe.Location = new System.Drawing.Point(0, 220);
            this.dtgvThongKe.Name = "dtgvThongKe";
            this.dtgvThongKe.ReadOnly = true;
            this.dtgvThongKe.Size = new System.Drawing.Size(645, 230);
            this.dtgvThongKe.TabIndex = 29;
            // 
            // cbbMonth
            // 
            this.cbbMonth.FormattingEnabled = true;
            this.cbbMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbbMonth.Location = new System.Drawing.Point(328, 83);
            this.cbbMonth.Name = "cbbMonth";
            this.cbbMonth.Size = new System.Drawing.Size(172, 21);
            this.cbbMonth.TabIndex = 30;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(328, 126);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(172, 20);
            this.txtYear.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(123, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Tháng cần thống kê:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(123, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Năm cần thống kê:";
            // 
            // btnThongKeThang
            // 
            this.btnThongKeThang.BackColor = System.Drawing.Color.DarkOrange;
            this.btnThongKeThang.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKeThang.Location = new System.Drawing.Point(69, 168);
            this.btnThongKeThang.Name = "btnThongKeThang";
            this.btnThongKeThang.Size = new System.Drawing.Size(146, 32);
            this.btnThongKeThang.TabIndex = 34;
            this.btnThongKeThang.Text = "Thống kê tháng";
            this.btnThongKeThang.UseVisualStyleBackColor = false;
            this.btnThongKeThang.Click += new System.EventHandler(this.btnThongKeThang_Click);
            // 
            // btnThongKeNam
            // 
            this.btnThongKeNam.BackColor = System.Drawing.Color.DarkOrange;
            this.btnThongKeNam.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKeNam.Location = new System.Drawing.Point(257, 168);
            this.btnThongKeNam.Name = "btnThongKeNam";
            this.btnThongKeNam.Size = new System.Drawing.Size(146, 32);
            this.btnThongKeNam.TabIndex = 35;
            this.btnThongKeNam.Text = "Thống kê năm";
            this.btnThongKeNam.UseVisualStyleBackColor = false;
            this.btnThongKeNam.Click += new System.EventHandler(this.btnThongKeNam_Click);
            // 
            // btnIn
            // 
            this.btnIn.BackColor = System.Drawing.Color.DarkOrange;
            this.btnIn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn.Location = new System.Drawing.Point(442, 168);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(146, 32);
            this.btnIn.TabIndex = 36;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = false;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SandyBrown;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(559, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 32);
            this.button1.TabIndex = 37;
            this.button1.Text = "Quay lại";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(645, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnThongKeNam);
            this.Controls.Add(this.btnThongKeThang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.cbbMonth);
            this.Controls.Add(this.dtgvThongKe);
            this.Controls.Add(this.label6);
            this.MaximizeBox = false;
            this.Name = "ThongKe";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống Kê";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ThongKe_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvThongKe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dtgvThongKe;
        private System.Windows.Forms.ComboBox cbbMonth;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThongKeThang;
        private System.Windows.Forms.Button btnThongKeNam;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button button1;
    }
}