namespace GUI
{
    partial class TrangChuST
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrangChuST));
            this.bntDangXuat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bntChangePass = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPositionStaff = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPhoneStaff = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAccountStaff = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNameStaff = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdStaff = new System.Windows.Forms.TextBox();
            this.bntThanhToan = new System.Windows.Forms.Button();
            this.bntDangKyVip = new System.Windows.Forms.Button();
            this.bntQuanLyBan = new System.Windows.Forms.Button();
            this.bntXemCaLam = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bntDangXuat
            // 
            this.bntDangXuat.BackColor = System.Drawing.Color.SandyBrown;
            this.bntDangXuat.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntDangXuat.Location = new System.Drawing.Point(670, 12);
            this.bntDangXuat.Name = "bntDangXuat";
            this.bntDangXuat.Size = new System.Drawing.Size(108, 25);
            this.bntDangXuat.TabIndex = 0;
            this.bntDangXuat.Text = "Đăng Xuất";
            this.bntDangXuat.UseVisualStyleBackColor = false;
            this.bntDangXuat.Click += new System.EventHandler(this.bntDangXuat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(239, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 65);
            this.label1.TabIndex = 1;
            this.label1.Text = "TRANG CHỦ";
            // 
            // bntChangePass
            // 
            this.bntChangePass.BackColor = System.Drawing.Color.SandyBrown;
            this.bntChangePass.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntChangePass.Location = new System.Drawing.Point(670, 43);
            this.bntChangePass.Name = "bntChangePass";
            this.bntChangePass.Size = new System.Drawing.Size(108, 25);
            this.bntChangePass.TabIndex = 4;
            this.bntChangePass.Text = "Đổi Mật Khẩu";
            this.bntChangePass.UseVisualStyleBackColor = false;
            this.bntChangePass.Click += new System.EventHandler(this.bntChangePass_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SandyBrown;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtPositionStaff);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtPhoneStaff);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtAccountStaff);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNameStaff);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtIdStaff);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(21, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 314);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin cá nhân";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(9, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Vị trí:";
            // 
            // txtPositionStaff
            // 
            this.txtPositionStaff.BackColor = System.Drawing.Color.Bisque;
            this.txtPositionStaff.Location = new System.Drawing.Point(91, 274);
            this.txtPositionStaff.Name = "txtPositionStaff";
            this.txtPositionStaff.ReadOnly = true;
            this.txtPositionStaff.Size = new System.Drawing.Size(266, 27);
            this.txtPositionStaff.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(9, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Phone:";
            // 
            // txtPhoneStaff
            // 
            this.txtPhoneStaff.BackColor = System.Drawing.Color.Bisque;
            this.txtPhoneStaff.Location = new System.Drawing.Point(91, 218);
            this.txtPhoneStaff.Name = "txtPhoneStaff";
            this.txtPhoneStaff.ReadOnly = true;
            this.txtPhoneStaff.Size = new System.Drawing.Size(266, 27);
            this.txtPhoneStaff.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(6, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Tài khoản:";
            // 
            // txtAccountStaff
            // 
            this.txtAccountStaff.BackColor = System.Drawing.Color.Bisque;
            this.txtAccountStaff.Location = new System.Drawing.Point(91, 161);
            this.txtAccountStaff.Name = "txtAccountStaff";
            this.txtAccountStaff.ReadOnly = true;
            this.txtAccountStaff.Size = new System.Drawing.Size(266, 27);
            this.txtAccountStaff.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(6, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Họ tên:";
            // 
            // txtNameStaff
            // 
            this.txtNameStaff.BackColor = System.Drawing.Color.Bisque;
            this.txtNameStaff.Location = new System.Drawing.Point(91, 103);
            this.txtNameStaff.Name = "txtNameStaff";
            this.txtNameStaff.ReadOnly = true;
            this.txtNameStaff.Size = new System.Drawing.Size(266, 27);
            this.txtNameStaff.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Mã số:";
            // 
            // txtIdStaff
            // 
            this.txtIdStaff.BackColor = System.Drawing.Color.Bisque;
            this.txtIdStaff.Location = new System.Drawing.Point(91, 44);
            this.txtIdStaff.Name = "txtIdStaff";
            this.txtIdStaff.ReadOnly = true;
            this.txtIdStaff.Size = new System.Drawing.Size(266, 27);
            this.txtIdStaff.TabIndex = 10;
            // 
            // bntThanhToan
            // 
            this.bntThanhToan.BackColor = System.Drawing.Color.DarkOrange;
            this.bntThanhToan.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntThanhToan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bntThanhToan.Location = new System.Drawing.Point(521, 178);
            this.bntThanhToan.Name = "bntThanhToan";
            this.bntThanhToan.Size = new System.Drawing.Size(222, 43);
            this.bntThanhToan.TabIndex = 11;
            this.bntThanhToan.Text = "Thanh toán";
            this.bntThanhToan.UseVisualStyleBackColor = false;
            this.bntThanhToan.Click += new System.EventHandler(this.bntThanhToan_Click);
            // 
            // bntDangKyVip
            // 
            this.bntDangKyVip.BackColor = System.Drawing.Color.DarkOrange;
            this.bntDangKyVip.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntDangKyVip.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bntDangKyVip.Location = new System.Drawing.Point(521, 267);
            this.bntDangKyVip.Name = "bntDangKyVip";
            this.bntDangKyVip.Size = new System.Drawing.Size(222, 43);
            this.bntDangKyVip.TabIndex = 10;
            this.bntDangKyVip.Text = "Đăng ký VIP";
            this.bntDangKyVip.UseVisualStyleBackColor = false;
            this.bntDangKyVip.Click += new System.EventHandler(this.bntDangKyVip_Click);
            // 
            // bntQuanLyBan
            // 
            this.bntQuanLyBan.BackColor = System.Drawing.Color.DarkOrange;
            this.bntQuanLyBan.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntQuanLyBan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bntQuanLyBan.Location = new System.Drawing.Point(521, 85);
            this.bntQuanLyBan.Name = "bntQuanLyBan";
            this.bntQuanLyBan.Size = new System.Drawing.Size(222, 43);
            this.bntQuanLyBan.TabIndex = 8;
            this.bntQuanLyBan.Text = "Quản lý bàn";
            this.bntQuanLyBan.UseVisualStyleBackColor = false;
            this.bntQuanLyBan.Click += new System.EventHandler(this.bntQuanLyBan_Click);
            // 
            // bntXemCaLam
            // 
            this.bntXemCaLam.BackColor = System.Drawing.Color.DarkOrange;
            this.bntXemCaLam.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntXemCaLam.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bntXemCaLam.Location = new System.Drawing.Point(521, 359);
            this.bntXemCaLam.Name = "bntXemCaLam";
            this.bntXemCaLam.Size = new System.Drawing.Size(222, 43);
            this.bntXemCaLam.TabIndex = 12;
            this.bntXemCaLam.Text = "Xem ca làm";
            this.bntXemCaLam.UseVisualStyleBackColor = false;
            this.bntXemCaLam.Click += new System.EventHandler(this.bntXemCaLam_Click);
            // 
            // TrangChuST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(805, 419);
            this.Controls.Add(this.bntXemCaLam);
            this.Controls.Add(this.bntThanhToan);
            this.Controls.Add(this.bntDangKyVip);
            this.Controls.Add(this.bntQuanLyBan);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bntChangePass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bntDangXuat);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "TrangChuST";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chủ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TrangChuST_FormClosed);
            this.Load += new System.EventHandler(this.TrangChuST_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntDangXuat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bntChangePass;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bntThanhToan;
        private System.Windows.Forms.Button bntDangKyVip;
        private System.Windows.Forms.Button bntQuanLyBan;
        private System.Windows.Forms.Button bntXemCaLam;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPositionStaff;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPhoneStaff;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAccountStaff;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNameStaff;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdStaff;
    }
}