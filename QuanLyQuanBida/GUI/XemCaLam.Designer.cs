namespace GUI
{
    partial class XemCaLam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XemCaLam));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvShifts = new System.Windows.Forms.DataGridView();
            this.cbbThang = new System.Windows.Forms.ComboBox();
            this.cbbTuan = new System.Windows.Forms.ComboBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.bntQuayLai = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShifts)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(247, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 65);
            this.label1.TabIndex = 2;
            this.label1.Text = "TRANG CHỦ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.dgvShifts);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 346);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Các ca làm trong tuần:";
            // 
            // dgvShifts
            // 
            this.dgvShifts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShifts.BackgroundColor = System.Drawing.Color.Bisque;
            this.dgvShifts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShifts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvShifts.Location = new System.Drawing.Point(3, 25);
            this.dgvShifts.Name = "dgvShifts";
            this.dgvShifts.Size = new System.Drawing.Size(794, 318);
            this.dgvShifts.TabIndex = 0;
            // 
            // cbbThang
            // 
            this.cbbThang.BackColor = System.Drawing.Color.Bisque;
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
            this.cbbThang.Location = new System.Drawing.Point(73, 47);
            this.cbbThang.Name = "cbbThang";
            this.cbbThang.Size = new System.Drawing.Size(121, 21);
            this.cbbThang.TabIndex = 18;
            this.cbbThang.SelectedIndexChanged += new System.EventHandler(this.cbbThang_SelectedIndexChanged);
            // 
            // cbbTuan
            // 
            this.cbbTuan.BackColor = System.Drawing.Color.Bisque;
            this.cbbTuan.Enabled = false;
            this.cbbTuan.FormattingEnabled = true;
            this.cbbTuan.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbbTuan.Location = new System.Drawing.Point(73, 74);
            this.cbbTuan.Name = "cbbTuan";
            this.cbbTuan.Size = new System.Drawing.Size(121, 21);
            this.cbbTuan.TabIndex = 17;
            this.cbbTuan.SelectedIndexChanged += new System.EventHandler(this.cbbTuan_SelectedIndexChanged);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.Transparent;
            this.label31.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.Color.SandyBrown;
            this.label31.Location = new System.Drawing.Point(7, 44);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(59, 21);
            this.label31.TabIndex = 16;
            this.label31.Text = "Tháng:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.BackColor = System.Drawing.Color.Transparent;
            this.label30.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.Color.SandyBrown;
            this.label30.Location = new System.Drawing.Point(7, 74);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(48, 21);
            this.label30.TabIndex = 15;
            this.label30.Text = "Tuần:";
            // 
            // bntQuayLai
            // 
            this.bntQuayLai.BackColor = System.Drawing.Color.Bisque;
            this.bntQuayLai.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntQuayLai.Location = new System.Drawing.Point(713, 12);
            this.bntQuayLai.Name = "bntQuayLai";
            this.bntQuayLai.Size = new System.Drawing.Size(75, 29);
            this.bntQuayLai.TabIndex = 19;
            this.bntQuayLai.Text = "Quay lại";
            this.bntQuayLai.UseVisualStyleBackColor = false;
            this.bntQuayLai.Click += new System.EventHandler(this.bntQuayLai_Click);
            // 
            // XemCaLam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bntQuayLai);
            this.Controls.Add(this.cbbThang);
            this.Controls.Add(this.cbbTuan);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "XemCaLam";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XemCaLam";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.XemCaLam_FormClosed);
            this.Load += new System.EventHandler(this.XemCaLam_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShifts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbThang;
        private System.Windows.Forms.ComboBox cbbTuan;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.DataGridView dgvShifts;
        private System.Windows.Forms.Button bntQuayLai;
    }
}