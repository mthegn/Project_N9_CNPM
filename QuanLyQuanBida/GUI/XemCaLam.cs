using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class XemCaLam : Form
    {
        string idPre;
        string passPre;
        int accessPre;
        BUS_Shifts BUS_Shifts;
        public XemCaLam(string id, string pass, int access)
        {
            InitializeComponent();
            idPre = id; passPre = pass; accessPre = access;
            BUS_Shifts = new BUS_Shifts();
        }

        private void cbbThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbThang.SelectedItem != null)
            {
                cbbTuan.Enabled = true;
            }
            if (cbbTuan.SelectedItem != null)
            {
                dgvShifts.Rows.Clear();
                int month = Convert.ToInt32(cbbThang.SelectedItem);
                int week = Convert.ToInt32(cbbTuan.SelectedItem);
                LoadData(month, week);
            }
        }

        private void cbbTuan_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvShifts.Rows.Clear();
            int month = Convert.ToInt32(cbbThang.SelectedItem);
            int week = Convert.ToInt32(cbbTuan.SelectedItem);

            LoadData(month, week);
        }

        private void LoadData(int month, int week)
        {
            List<DTO_Shifts> list = new List<DTO_Shifts>();
            list = BUS_Shifts.GetShiftOfStaff_BUS(idPre, month, week);

            dgvShifts.ColumnCount = 5;

            dgvShifts.Columns[0].Name = "Mã ca";
            dgvShifts.Columns[1].Name = "Ngày";
            dgvShifts.Columns[2].Name = "Ca làm";
            dgvShifts.Columns[3].Name = "Tuần";
            dgvShifts.Columns[4].Name = "Tháng";

            dgvShifts.Rows.Clear();

            foreach (DTO_Shifts temp in list)
            {
                dgvShifts.Rows.Add(temp.IDShift, temp.TimeLine.Date.ToString("dd/MM/yyyy"), temp.Shift, temp.Week, temp.Month);
            }
        }

        private void bntQuayLai_Click(object sender, EventArgs e)
        {
            TrangChuST trangChu = new TrangChuST(idPre, passPre, accessPre);
            trangChu.Show();
            this.Hide();
        }

        private void XemCaLam_FormClosed(object sender, FormClosedEventArgs e)
        {
            TrangChuST trangChu = new TrangChuST(idPre, passPre, accessPre);
            trangChu.Show();
            this.Hide();
        }

        private void XemCaLam_Load(object sender, EventArgs e)
        {
            if (cbbThang == null)
            {
                cbbTuan.Enabled = false;
            }
        }
    }
}
