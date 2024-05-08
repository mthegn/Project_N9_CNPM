namespace GUI
{
    partial class DangKyVIP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangKyVIP));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.bntDangKy = new System.Windows.Forms.Button();
            this.bntHuy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(164, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐĂNG KÝ VIP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(49, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên khách hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.Location = new System.Drawing.Point(49, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số điện thoại:";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.Bisque;
            this.txtName.Location = new System.Drawing.Point(246, 141);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(353, 20);
            this.txtName.TabIndex = 3;
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.Bisque;
            this.txtPhone.Location = new System.Drawing.Point(246, 191);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(353, 20);
            this.txtPhone.TabIndex = 4;
            // 
            // bntDangKy
            // 
            this.bntDangKy.BackColor = System.Drawing.Color.DarkOrange;
            this.bntDangKy.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntDangKy.Location = new System.Drawing.Point(175, 266);
            this.bntDangKy.Name = "bntDangKy";
            this.bntDangKy.Size = new System.Drawing.Size(137, 55);
            this.bntDangKy.TabIndex = 5;
            this.bntDangKy.Text = "Đăng ký";
            this.bntDangKy.UseVisualStyleBackColor = false;
            this.bntDangKy.Click += new System.EventHandler(this.bntDangKy_Click);
            // 
            // bntHuy
            // 
            this.bntHuy.BackColor = System.Drawing.Color.SandyBrown;
            this.bntHuy.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntHuy.Location = new System.Drawing.Point(358, 266);
            this.bntHuy.Name = "bntHuy";
            this.bntHuy.Size = new System.Drawing.Size(137, 55);
            this.bntHuy.TabIndex = 6;
            this.bntHuy.Text = "Hủy";
            this.bntHuy.UseVisualStyleBackColor = false;
            this.bntHuy.Click += new System.EventHandler(this.bntHuy_Click);
            // 
            // DangKyVIP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(663, 384);
            this.Controls.Add(this.bntHuy);
            this.Controls.Add(this.bntDangKy);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "DangKyVIP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng_Ký_VIP";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DangKyVIP_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button bntDangKy;
        private System.Windows.Forms.Button bntHuy;
    }
}