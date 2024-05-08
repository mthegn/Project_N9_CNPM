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
    public partial class DangKyVIP : Form
    {
        private string userpresent;
        private string passpresent;
        private int accesspresent;

        BUS_VIP bus;
        DTO_VIP vip;
        DTO_Users userpre;
        public DangKyVIP(string user, string pass, int idAccess)
        {
            InitializeComponent();
            userpre = new DTO_Users();
            userpresent = user;
            passpresent = pass;
            accesspresent = idAccess;
            bus = new BUS_VIP();
            vip = new DTO_VIP();
            userpre.User = user;
            userpre.Pass = pass;
            userpre.IdAccess = idAccess;
        }

        private void bntHuy_Click(object sender, EventArgs e)
        {
            TrangChuST st = new TrangChuST(userpresent, passpresent, accesspresent);
            st.Show();
            this.Hide();
        }

        private void bntDangKy_Click(object sender, EventArgs e)
        {
            string nameKH = txtName.Text;
            string phone = txtPhone.Text;

            vip.Name = nameKH;
            vip.Phone = phone;

            bus.CreateVIP_BUS(vip);
            if (bus.CreateVIP_BUS(vip))
            {
                MessageBox.Show("Create VIP account successful!");
                TrangChuST trangChuST = new TrangChuST(userpresent, passpresent, accesspresent);
                trangChuST.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Phone number was created or Not enter full information.");
            }
        }

        private void DangKyVIP_FormClosed(object sender, FormClosedEventArgs e)
        {
            TrangChuST st = new TrangChuST(userpresent, passpresent, accesspresent);
            st.Show();
            this.Hide();
        }
    }
}
