namespace GUI
{
    partial class TrangChuQL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrangChuQL));
            this.bntDangXuat = new System.Windows.Forms.Button();
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
            this.bntPhanCongCaLam = new System.Windows.Forms.Button();
            this.bntThongKeDoanhThu = new System.Windows.Forms.Button();
            this.bntThanhToanLuong = new System.Windows.Forms.Button();
            this.bntQuanLyNhanVien = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            // bntChangePass
            // 
            this.bntChangePass.BackColor = System.Drawing.Color.SandyBrown;
            this.bntChangePass.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntChangePass.Location = new System.Drawing.Point(670, 43);
            this.bntChangePass.Name = "bntChangePass";
            this.bntChangePass.Size = new System.Drawing.Size(108, 25);
            this.bntChangePass.TabIndex = 1;
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
            this.groupBox1.Location = new System.Drawing.Point(21, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 317);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin cá nhân";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Vị trí:";
            // 
            // txtPositionStaff
            // 
            this.txtPositionStaff.BackColor = System.Drawing.Color.Bisque;
            this.txtPositionStaff.Location = new System.Drawing.Point(91, 274);
            this.txtPositionStaff.Name = "txtPositionStaff";
            this.txtPositionStaff.ReadOnly = true;
            this.txtPositionStaff.Size = new System.Drawing.Size(266, 27);
            this.txtPositionStaff.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Phone:";
            // 
            // txtPhoneStaff
            // 
            this.txtPhoneStaff.BackColor = System.Drawing.Color.Bisque;
            this.txtPhoneStaff.Location = new System.Drawing.Point(91, 218);
            this.txtPhoneStaff.Name = "txtPhoneStaff";
            this.txtPhoneStaff.ReadOnly = true;
            this.txtPhoneStaff.Size = new System.Drawing.Size(266, 27);
            this.txtPhoneStaff.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tài khoản:";
            // 
            // txtAccountStaff
            // 
            this.txtAccountStaff.BackColor = System.Drawing.Color.Bisque;
            this.txtAccountStaff.Location = new System.Drawing.Point(91, 161);
            this.txtAccountStaff.Name = "txtAccountStaff";
            this.txtAccountStaff.ReadOnly = true;
            this.txtAccountStaff.Size = new System.Drawing.Size(266, 27);
            this.txtAccountStaff.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Họ tên:";
            // 
            // txtNameStaff
            // 
            this.txtNameStaff.BackColor = System.Drawing.Color.Bisque;
            this.txtNameStaff.Location = new System.Drawing.Point(91, 103);
            this.txtNameStaff.Name = "txtNameStaff";
            this.txtNameStaff.ReadOnly = true;
            this.txtNameStaff.Size = new System.Drawing.Size(266, 27);
            this.txtNameStaff.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã số:";
            // 
            // txtIdStaff
            // 
            this.txtIdStaff.BackColor = System.Drawing.Color.Bisque;
            this.txtIdStaff.Location = new System.Drawing.Point(91, 44);
            this.txtIdStaff.Name = "txtIdStaff";
            this.txtIdStaff.ReadOnly = true;
            this.txtIdStaff.Size = new System.Drawing.Size(266, 27);
            this.txtIdStaff.TabIndex = 0;
            // 
            // bntPhanCongCaLam
            // 
            this.bntPhanCongCaLam.BackColor = System.Drawing.Color.DarkOrange;
            this.bntPhanCongCaLam.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntPhanCongCaLam.Location = new System.Drawing.Point(521, 178);
            this.bntPhanCongCaLam.Name = "bntPhanCongCaLam";
            this.bntPhanCongCaLam.Size = new System.Drawing.Size(222, 43);
            this.bntPhanCongCaLam.TabIndex = 7;
            this.bntPhanCongCaLam.Text = "Phân công ca làm";
            this.bntPhanCongCaLam.UseVisualStyleBackColor = false;
            this.bntPhanCongCaLam.Click += new System.EventHandler(this.bntPhanCongCaLam_Click);
            // 
            // bntThongKeDoanhThu
            // 
            this.bntThongKeDoanhThu.BackColor = System.Drawing.Color.DarkOrange;
            this.bntThongKeDoanhThu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntThongKeDoanhThu.Location = new System.Drawing.Point(521, 267);
            this.bntThongKeDoanhThu.Name = "bntThongKeDoanhThu";
            this.bntThongKeDoanhThu.Size = new System.Drawing.Size(222, 43);
            this.bntThongKeDoanhThu.TabIndex = 6;
            this.bntThongKeDoanhThu.Text = "Thống kê doanh thu";
            this.bntThongKeDoanhThu.UseVisualStyleBackColor = false;
            this.bntThongKeDoanhThu.Click += new System.EventHandler(this.bntThongKeDoanhThu_Click);
            // 
            // bntThanhToanLuong
            // 
            this.bntThanhToanLuong.BackColor = System.Drawing.Color.DarkOrange;
            this.bntThanhToanLuong.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntThanhToanLuong.Location = new System.Drawing.Point(521, 359);
            this.bntThanhToanLuong.Name = "bntThanhToanLuong";
            this.bntThanhToanLuong.Size = new System.Drawing.Size(222, 43);
            this.bntThanhToanLuong.TabIndex = 5;
            this.bntThanhToanLuong.Text = "Thanh toán lương";
            this.bntThanhToanLuong.UseVisualStyleBackColor = false;
            this.bntThanhToanLuong.Click += new System.EventHandler(this.bntThanhToanLuong_Click);
            // 
            // bntQuanLyNhanVien
            // 
            this.bntQuanLyNhanVien.BackColor = System.Drawing.Color.DarkOrange;
            this.bntQuanLyNhanVien.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntQuanLyNhanVien.Location = new System.Drawing.Point(521, 85);
            this.bntQuanLyNhanVien.Name = "bntQuanLyNhanVien";
            this.bntQuanLyNhanVien.Size = new System.Drawing.Size(222, 43);
            this.bntQuanLyNhanVien.TabIndex = 4;
            this.bntQuanLyNhanVien.Text = "Quản lý nhân viên";
            this.bntQuanLyNhanVien.UseVisualStyleBackColor = false;
            this.bntQuanLyNhanVien.Click += new System.EventHandler(this.bntQuanLyNhanVien_Click);
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
            this.label1.TabIndex = 8;
            this.label1.Text = "TRANG CHỦ";
            // 
            // TrangChuQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(804, 420);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bntPhanCongCaLam);
            this.Controls.Add(this.bntThongKeDoanhThu);
            this.Controls.Add(this.bntThanhToanLuong);
            this.Controls.Add(this.bntQuanLyNhanVien);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bntChangePass);
            this.Controls.Add(this.bntDangXuat);
            this.MaximizeBox = false;
            this.Name = "TrangChuQL";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chủ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TrangChuQL_FormClosed);
            this.Load += new System.EventHandler(this.TrangChuQL_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntDangXuat;
        private System.Windows.Forms.Button bntChangePass;
        private System.Windows.Forms.Button bntPhanCongCaLam;
        private System.Windows.Forms.Button bntThongKeDoanhThu;
        private System.Windows.Forms.Button bntThanhToanLuong;
        private System.Windows.Forms.Button bntQuanLyNhanVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAccountStaff;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNameStaff;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdStaff;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPositionStaff;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPhoneStaff;
    }
}