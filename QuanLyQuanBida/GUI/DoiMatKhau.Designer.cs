namespace GUI
{
    partial class DoiMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoiMatKhau));
            this.txtOldPass = new System.Windows.Forms.TextBox();
            this.txtNewPass = new System.Windows.Forms.MaskedTextBox();
            this.txtAcpPass = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bntXacNhan = new System.Windows.Forms.Button();
            this.bntHuy = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtOldPass
            // 
            this.txtOldPass.BackColor = System.Drawing.Color.Bisque;
            this.txtOldPass.Location = new System.Drawing.Point(259, 96);
            this.txtOldPass.Name = "txtOldPass";
            this.txtOldPass.PasswordChar = '8';
            this.txtOldPass.Size = new System.Drawing.Size(227, 20);
            this.txtOldPass.TabIndex = 0;
            this.txtOldPass.UseSystemPasswordChar = true;
            // 
            // txtNewPass
            // 
            this.txtNewPass.BackColor = System.Drawing.Color.Bisque;
            this.txtNewPass.Location = new System.Drawing.Point(259, 140);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.PasswordChar = '8';
            this.txtNewPass.Size = new System.Drawing.Size(227, 20);
            this.txtNewPass.TabIndex = 1;
            this.txtNewPass.UseSystemPasswordChar = true;
            // 
            // txtAcpPass
            // 
            this.txtAcpPass.BackColor = System.Drawing.Color.Bisque;
            this.txtAcpPass.Location = new System.Drawing.Point(259, 184);
            this.txtAcpPass.Name = "txtAcpPass";
            this.txtAcpPass.PasswordChar = '8';
            this.txtAcpPass.Size = new System.Drawing.Size(227, 20);
            this.txtAcpPass.TabIndex = 2;
            this.txtAcpPass.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(104, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mật khẩu cũ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(104, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mật khẩu mới:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.Location = new System.Drawing.Point(104, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Xác nhận mật khẩu:";
            // 
            // bntXacNhan
            // 
            this.bntXacNhan.BackColor = System.Drawing.Color.DarkOrange;
            this.bntXacNhan.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntXacNhan.Location = new System.Drawing.Point(152, 242);
            this.bntXacNhan.Name = "bntXacNhan";
            this.bntXacNhan.Size = new System.Drawing.Size(123, 58);
            this.bntXacNhan.TabIndex = 6;
            this.bntXacNhan.Text = "Xác nhận";
            this.bntXacNhan.UseVisualStyleBackColor = false;
            this.bntXacNhan.Click += new System.EventHandler(this.bntXacNhan_Click);
            // 
            // bntHuy
            // 
            this.bntHuy.BackColor = System.Drawing.Color.SandyBrown;
            this.bntHuy.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntHuy.Location = new System.Drawing.Point(317, 242);
            this.bntHuy.Name = "bntHuy";
            this.bntHuy.Size = new System.Drawing.Size(123, 58);
            this.bntHuy.TabIndex = 7;
            this.bntHuy.Text = "Hủy";
            this.bntHuy.UseVisualStyleBackColor = false;
            this.bntHuy.Click += new System.EventHandler(this.bntHuy_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkOrange;
            this.label4.Location = new System.Drawing.Point(174, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(261, 45);
            this.label4.TabIndex = 8;
            this.label4.Text = "ĐỔI MẬT KHẨU";
            // 
            // DoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(586, 333);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bntHuy);
            this.Controls.Add(this.bntXacNhan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAcpPass);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.txtOldPass);
            this.MaximizeBox = false;
            this.Name = "DoiMatKhau";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi Mật Khẩu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DoiMatKhau_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOldPass;
        private System.Windows.Forms.MaskedTextBox txtNewPass;
        private System.Windows.Forms.MaskedTextBox txtAcpPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bntXacNhan;
        private System.Windows.Forms.Button bntHuy;
        private System.Windows.Forms.Label label4;
    }
}