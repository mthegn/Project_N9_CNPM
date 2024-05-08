namespace GUI
{
    partial class ThanhToanLuong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThanhToanLuong));
            this.cbbThang = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLuongTheoCa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalPrint = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbIDStaff = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbbThang
            // 
            this.cbbThang.FormattingEnabled = true;
            this.cbbThang.Items.AddRange(new object[] {
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
            this.cbbThang.Location = new System.Drawing.Point(287, 133);
            this.cbbThang.Name = "cbbThang";
            this.cbbThang.Size = new System.Drawing.Size(195, 21);
            this.cbbThang.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(140, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tháng thanh toán:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(140, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã nhân viên:";
            // 
            // txtLuongTheoCa
            // 
            this.txtLuongTheoCa.Location = new System.Drawing.Point(287, 208);
            this.txtLuongTheoCa.Name = "txtLuongTheoCa";
            this.txtLuongTheoCa.Size = new System.Drawing.Size(195, 20);
            this.txtLuongTheoCa.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.Location = new System.Drawing.Point(140, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mức lương theo ca:";
            // 
            // btnCalPrint
            // 
            this.btnCalPrint.BackColor = System.Drawing.Color.DarkOrange;
            this.btnCalPrint.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalPrint.Location = new System.Drawing.Point(152, 259);
            this.btnCalPrint.Name = "btnCalPrint";
            this.btnCalPrint.Size = new System.Drawing.Size(138, 43);
            this.btnCalPrint.TabIndex = 6;
            this.btnCalPrint.Text = "Tính và in hóa đơn";
            this.btnCalPrint.UseVisualStyleBackColor = false;
            this.btnCalPrint.Click += new System.EventHandler(this.btnCalPrint_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.DarkOrange;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(356, 259);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(138, 43);
            this.btnHuy.TabIndex = 7;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkOrange;
            this.label6.Location = new System.Drawing.Point(59, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(533, 65);
            this.label6.TabIndex = 22;
            this.label6.Text = "THANH TOÁN LƯƠNG";
            // 
            // cbbIDStaff
            // 
            this.cbbIDStaff.FormattingEnabled = true;
            this.cbbIDStaff.Location = new System.Drawing.Point(287, 171);
            this.cbbIDStaff.Name = "cbbIDStaff";
            this.cbbIDStaff.Size = new System.Drawing.Size(195, 21);
            this.cbbIDStaff.TabIndex = 23;
            // 
            // ThanhToanLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(650, 342);
            this.Controls.Add(this.cbbIDStaff);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnCalPrint);
            this.Controls.Add(this.txtLuongTheoCa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbThang);
            this.Name = "ThanhToanLuong";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThanhToanLuong";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ThanhToanLuong_FormClosed);
            this.Load += new System.EventHandler(this.ThanhToanLuong_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbThang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLuongTheoCa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalPrint;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbIDStaff;
    }
}