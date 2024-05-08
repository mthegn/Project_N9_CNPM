using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace GUI
{
    public partial class CapNhatCaLam : Form
    {
        BUS_Shifts busShifts;
        BUS_Staff BUS_Staff;

        string shiftPre;
        string idPre;
        string passPre;
        int accPre;
        int monthPre;
        int weekPre;
        public CapNhatCaLam(string shift, int month, int week, string id, string pass, int access)
        {
            InitializeComponent();
            busShifts = new BUS_Shifts();
            BUS_Staff = new BUS_Staff();

            shiftPre = shift;
            idPre = id;
            passPre = pass;
            accPre = access;
            monthPre = month;
            weekPre = week;
        }

        private void bntHuy_Click(object sender, EventArgs e)
        {
            PhanCongCaLam phanCong = new PhanCongCaLam(idPre, passPre, accPre, monthPre, weekPre);
            phanCong.Show();
            this.Hide();
        }

        private void bntXacNhan_Click(object sender, EventArgs e)
        {
            DateTime time = dtpNgayLam.Value;
            string idStaff = cbbIDStaff.SelectedItem.ToString();

            if (string.IsNullOrEmpty(idStaff))
            {
                MessageBox.Show("ID staff is null.");
            }
            else
            {
                if (busShifts.UpdateShift_BUS(shiftPre, monthPre, weekPre, idStaff, time))
                {
                    busShifts.UpdateShift_BUS(shiftPre, monthPre, weekPre, idStaff, time);
                    MessageBox.Show("Successful update!");

                    PhanCongCaLam phanCong = new PhanCongCaLam(idPre, passPre, accPre, monthPre, weekPre);
                    phanCong.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Update failed.");
                }
            }
        }

        private void CapNhatCaLam_FormClosed(object sender, FormClosedEventArgs e)
        {
            PhanCongCaLam phanCong = new PhanCongCaLam(idPre, passPre, accPre, monthPre, weekPre);
            phanCong.Show();
            this.Hide();
        }

        private void CapNhatCaLam_Load(object sender, EventArgs e)
        {
            List<string> idList = BUS_Staff.GetListID_BUS();

            foreach (string s in idList)
            {
                if (s == "NV0001")
                {
                    continue;
                }
                cbbIDStaff.Items.Add(s);
            }
        }
    }
}
