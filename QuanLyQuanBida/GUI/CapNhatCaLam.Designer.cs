namespace GUI
{
    partial class CapNhatCaLam
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CapNhatCaLam));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpNgayLam = new System.Windows.Forms.DateTimePicker();
            this.bntXacNhan = new System.Windows.Forms.Button();
            this.bntHuy = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbIDStaff = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(142, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID nhân viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(142, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ngày làm:";
            // 
            // dtpNgayLam
            // 
            this.dtpNgayLam.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayLam.Location = new System.Drawing.Point(242, 168);
            this.dtpNgayLam.Name = "dtpNgayLam";
            this.dtpNgayLam.Size = new System.Drawing.Size(200, 20);
            this.dtpNgayLam.TabIndex = 4;
            // 
            // bntXacNhan
            // 
            this.bntXacNhan.BackColor = System.Drawing.Color.DarkOrange;
            this.bntXacNhan.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntXacNhan.Location = new System.Drawing.Point(181, 248);
            this.bntXacNhan.Name = "bntXacNhan";
            this.bntXacNhan.Size = new System.Drawing.Size(75, 31);
            this.bntXacNhan.TabIndex = 5;
            this.bntXacNhan.Text = "Xác nhận";
            this.bntXacNhan.UseVisualStyleBackColor = false;
            this.bntXacNhan.Click += new System.EventHandler(this.bntXacNhan_Click);
            // 
            // bntHuy
            // 
            this.bntHuy.BackColor = System.Drawing.Color.DarkOrange;
            this.bntHuy.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntHuy.Location = new System.Drawing.Point(336, 248);
            this.bntHuy.Name = "bntHuy";
            this.bntHuy.Size = new System.Drawing.Size(75, 31);
            this.bntHuy.TabIndex = 6;
            this.bntHuy.Text = "Hủy";
            this.bntHuy.UseVisualStyleBackColor = false;
            this.bntHuy.Click += new System.EventHandler(this.bntHuy_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.Location = new System.Drawing.Point(97, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(358, 50);
            this.label3.TabIndex = 7;
            this.label3.Text = "CẬP NHẬT CA LÀM";
            // 
            // cbbIDStaff
            // 
            this.cbbIDStaff.FormattingEnabled = true;
            this.cbbIDStaff.Location = new System.Drawing.Point(242, 126);
            this.cbbIDStaff.Name = "cbbIDStaff";
            this.cbbIDStaff.Size = new System.Drawing.Size(200, 21);
            this.cbbIDStaff.TabIndex = 8;
            // 
            // CapNhatCaLam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(544, 316);
            this.Controls.Add(this.cbbIDStaff);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bntHuy);
            this.Controls.Add(this.bntXacNhan);
            this.Controls.Add(this.dtpNgayLam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CapNhatCaLam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CapNhatCaLam";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CapNhatCaLam_FormClosed);
            this.Load += new System.EventHandler(this.CapNhatCaLam_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpNgayLam;
        private System.Windows.Forms.Button bntXacNhan;
        private System.Windows.Forms.Button bntHuy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbIDStaff;
    }
}