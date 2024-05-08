using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace GUI
{
    public partial class PhanCongCaLam : Form
    {
        BUS_Shifts BUS_Shifts;
        string idPre;
        string passPre;
        int accessPre;
        int monthPre;
        int weekPre;
        public PhanCongCaLam(string id, string pass, int access, int month, int week)
        {
            InitializeComponent();
            BUS_Shifts = new BUS_Shifts();
            idPre = id;
            passPre = pass;
            accessPre = access;
            monthPre = month;
            weekPre = week;
        }

        private void PhanCongCaLam_Load(object sender, EventArgs e)
        {
            cbbThang.SelectedIndex = monthPre-1;
            cbbTuan.SelectedIndex = weekPre-1;
            if (cbbTuan.SelectedItem == null)
            {
                bntCa12.Enabled = false;
                bntCa13.Enabled = false;
                bntCa14.Enabled = false;
                bntCa15.Enabled = false;
                bntCa16.Enabled = false;
                bntCa17.Enabled = false;
                bntCa18.Enabled = false;
                bntCa22.Enabled = false;
                bntCa23.Enabled = false;
                bntCa24.Enabled = false;
                bntCa25.Enabled = false;
                bntCa26.Enabled = false;
                bntCa27.Enabled = false;
                bntCa28.Enabled = false;
                bntCa32.Enabled = false;
                bntCa33.Enabled = false;
                bntCa34.Enabled = false;
                bntCa35.Enabled = false;
                bntCa36.Enabled = false;
                bntCa37.Enabled = false;
                bntCa38.Enabled = false;
            }
            if (cbbThang.SelectedItem == null)
            {
                cbbTuan.Enabled = false;
            }
        }

        public void OpenFormCapNhatCaLam(string shift)
        {
            int month = Convert.ToInt32(cbbThang.SelectedItem);
            int week = Convert.ToInt32(cbbTuan.SelectedItem);
            CapNhatCaLam capNhat = new CapNhatCaLam(shift, month, week, idPre, passPre, accessPre);
            capNhat.ShowDialog();
            this.Hide();
        }

        private void bntCa12_Click(object sender, EventArgs e)
        {
            OpenFormCapNhatCaLam("12");
        }

        private void bntCa13_Click(object sender, EventArgs e)
        {
            OpenFormCapNhatCaLam("13");
        }

        private void bntCa14_Click(object sender, EventArgs e)
        {
            OpenFormCapNhatCaLam("14");
        }

        private void bntCa15_Click(object sender, EventArgs e)
        {
            OpenFormCapNhatCaLam("15");
        }

        private void bntCa16_Click(object sender, EventArgs e)
        {
            OpenFormCapNhatCaLam("16");
        }

        private void bntCa17_Click(object sender, EventArgs e)
        {
            OpenFormCapNhatCaLam("17");
        }

        private void bntCa18_Click(object sender, EventArgs e)
        {
            OpenFormCapNhatCaLam("18");
        }

        private void bntCa22_Click(object sender, EventArgs e)
        {
            OpenFormCapNhatCaLam("22");
        }

        private void bntCa23_Click(object sender, EventArgs e)
        {
            OpenFormCapNhatCaLam("23");
        }

        private void bntCa24_Click(object sender, EventArgs e)
        {
            OpenFormCapNhatCaLam("24");
        }

        private void bntCa25_Click(object sender, EventArgs e)
        {
            OpenFormCapNhatCaLam("25");
        }

        private void bntCa26_Click(object sender, EventArgs e)
        {
            OpenFormCapNhatCaLam("26");
        }

        private void bntCa27_Click(object sender, EventArgs e)
        {
            OpenFormCapNhatCaLam("27");
        }

        private void bntCa28_Click(object sender, EventArgs e)
        {
            OpenFormCapNhatCaLam("28");
        }

        private void bntCa32_Click(object sender, EventArgs e)
        {
            OpenFormCapNhatCaLam("32");
        }

        private void bntCa33_Click(object sender, EventArgs e)
        {
            OpenFormCapNhatCaLam("33");
        }

        private void bntCa34_Click(object sender, EventArgs e)
        {
            OpenFormCapNhatCaLam("34");
        }

        private void bntCa35_Click(object sender, EventArgs e)
        {
            OpenFormCapNhatCaLam("35");
        }

        private void bntCa36_Click(object sender, EventArgs e)
        {
            OpenFormCapNhatCaLam("36");
        }

        private void bntCa37_Click(object sender, EventArgs e)
        {
            OpenFormCapNhatCaLam("37");
        }

        private void bntCa38_Click(object sender, EventArgs e)
        {
            OpenFormCapNhatCaLam("38");
        }

        private void PhanCongCaLam_FormClosed(object sender, FormClosedEventArgs e)
        {
            TrangChuQL trangChu = new TrangChuQL(idPre, passPre, accessPre);
            trangChu.Show();
            this.Hide();
        }

        private void bntQuayLai_Click(object sender, EventArgs e)
        {
            TrangChuQL trangChu = new TrangChuQL(idPre, passPre, accessPre);
            trangChu.Show();
            this.Hide();
        }

        private void cbbThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbThang.SelectedItem != null)
            {
                cbbTuan.Enabled = true;
                monthPre = Convert.ToInt32(cbbThang.SelectedItem);
            }
            else
            {
                cbbTuan.Enabled = false;
            }
            if (cbbTuan.SelectedItem != null)
            {
                int month = Convert.ToInt32(cbbThang.SelectedItem);
                int week = Convert.ToInt32(cbbTuan.SelectedItem);
                weekPre = week;
                monthPre = month;
                LoadData(month, week);
            }
        }

        private void cbbTuan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTuan.SelectedItem != null)
            {
                int month = Convert.ToInt32(cbbThang.SelectedItem);
                int week = Convert.ToInt32(cbbTuan.SelectedItem);
                LoadData(month, week);

                bntCa12.Enabled = true;
                bntCa13.Enabled = true;
                bntCa14.Enabled = true;
                bntCa15.Enabled = true;
                bntCa16.Enabled = true;
                bntCa17.Enabled = true;
                bntCa18.Enabled = true;
                bntCa22.Enabled = true;
                bntCa23.Enabled = true;
                bntCa24.Enabled = true;
                bntCa25.Enabled = true;
                bntCa26.Enabled = true;
                bntCa27.Enabled = true;
                bntCa28.Enabled = true;
                bntCa32.Enabled = true;
                bntCa33.Enabled = true;
                bntCa34.Enabled = true;
                bntCa35.Enabled = true;
                bntCa36.Enabled = true;
                bntCa37.Enabled = true;
                bntCa38.Enabled = true;
            }
        }

        private void LoadData(int month, int week)
        {
            txtCa12.Text = BUS_Shifts.GetStaffShift_BUS("12", month, week);
            txtCa13.Text = BUS_Shifts.GetStaffShift_BUS("13", month, week);
            txtCa14.Text = BUS_Shifts.GetStaffShift_BUS("14", month, week);
            txtCa15.Text = BUS_Shifts.GetStaffShift_BUS("15", month, week);
            txtCa16.Text = BUS_Shifts.GetStaffShift_BUS("16", month, week);
            txtCa17.Text = BUS_Shifts.GetStaffShift_BUS("17", month, week);
            txtCa18.Text = BUS_Shifts.GetStaffShift_BUS("18", month, week);
            txtCa22.Text = BUS_Shifts.GetStaffShift_BUS("22", month, week);
            txtCa23.Text = BUS_Shifts.GetStaffShift_BUS("23", month, week);
            txtCa24.Text = BUS_Shifts.GetStaffShift_BUS("24", month, week);
            txtCa25.Text = BUS_Shifts.GetStaffShift_BUS("25", month, week);
            txtCa26.Text = BUS_Shifts.GetStaffShift_BUS("26", month, week);
            txtCa27.Text = BUS_Shifts.GetStaffShift_BUS("27", month, week);
            txtCa28.Text = BUS_Shifts.GetStaffShift_BUS("28", month, week);
            txtCa32.Text = BUS_Shifts.GetStaffShift_BUS("32", month, week);
            txtCa33.Text = BUS_Shifts.GetStaffShift_BUS("33", month, week);
            txtCa34.Text = BUS_Shifts.GetStaffShift_BUS("34", month, week);
            txtCa35.Text = BUS_Shifts.GetStaffShift_BUS("35", month, week);
            txtCa36.Text = BUS_Shifts.GetStaffShift_BUS("36", month, week);
            txtCa37.Text = BUS_Shifts.GetStaffShift_BUS("37", month, week);
            txtCa38.Text = BUS_Shifts.GetStaffShift_BUS("38", month, week);
        }
    }
}
