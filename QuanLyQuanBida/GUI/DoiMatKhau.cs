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
    public partial class DoiMatKhau : Form
    {
        private string us;
        private string ps;
        private int idAcc;
        BUS_Users chg;
        DTO_Users user1;
        public DoiMatKhau(string userPre, string passPre,int idAcc)
        {
            InitializeComponent();
            us = userPre;
            ps = passPre;
            this.idAcc = idAcc;
            chg = new BUS_Users();
            user1 = new DTO_Users();
        }

        private void bntXacNhan_Click(object sender, EventArgs e)
        {
            string oldPass = txtOldPass.Text;
            string newPass = txtNewPass.Text;
            string acpPass = txtAcpPass.Text;

            user1.User = us;
            user1.Pass = newPass;
            user1.IdAccess = idAcc;

            bool isPasswordChanged = chg.ChangePass_BUS(user1, oldPass, acpPass, ps);

            if (isPasswordChanged)
            {
                MessageBox.Show("Change password successful!");

                if (idAcc == 1)
                {
                    TrangChuQL trangChuQL = new TrangChuQL(us, newPass, idAcc);
                    trangChuQL.Show();
                    this.Hide();
                }
                else
                {
                    TrangChuST trangChuKT = new TrangChuST(us, newPass, idAcc);
                    trangChuKT.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Incorrect password or new password is the same as the old password.");
            }
        }

        private void DoiMatKhau_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (idAcc == 1)
            {
                TrangChuQL trangChuQL = new TrangChuQL(us,ps, idAcc);
                trangChuQL.Show();
                this.Hide();
            }
            else
            {
                TrangChuST trangChuKT = new TrangChuST(us, ps, idAcc);
                trangChuKT.Show();
                this.Hide();
            }
        }

        private void bntHuy_Click(object sender, EventArgs e)
        {
            if (idAcc == 1)
            {
                TrangChuQL trangChuQL = new TrangChuQL(us, ps, idAcc);
                trangChuQL.Show();
                this.Hide();
            }
            else
            {
                TrangChuST trangChuKT = new TrangChuST(us, ps, idAcc);
                trangChuKT.Show();
                this.Hide();
            }
        }

    }
}
