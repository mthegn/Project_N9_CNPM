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
    public partial class TrangChuST : Form
    {
        DTO_Users userPre;
        DTO_Staff staff;
        BUS_Staff bus;
        DTO_Staff staffToDatBan;
        private string userPresent;
        private string passPresent;
        private int accessPresent;
        private string idStaff;
        public TrangChuST(string user, string pass, int idAccess)
        {
            InitializeComponent();
            userPre = new DTO_Users();
            staff = new DTO_Staff();
            bus = new BUS_Staff();

            userPresent = user;
            passPresent = pass;
            accessPresent = idAccess;

            userPre.User = user;
            userPre.Pass = pass;
            userPre.IdAccess = idAccess;

            staff.Account = userPresent;
            staffToDatBan = new DTO_Staff();
            staffToDatBan = bus.GetStaffInfo_BUS(staff);
            idStaff = staffToDatBan.IdStaff;
        }

        private void bntDangXuat_Click(object sender, EventArgs e)
        {
            DangNhap dangNhap = new DangNhap();
            dangNhap.Show();
            this.Hide();
        }

        private void bntChangePass_Click(object sender, EventArgs e)
        {
            DoiMatKhau changepass = new DoiMatKhau(userPresent, passPresent, accessPresent);
            changepass.Show();
            this.Hide();
        }

        private void TrangChuST_Load(object sender, EventArgs e)
        {
            DTO_Staff staffInfo = bus.GetStaffInfo_BUS(staff);

            if (staffInfo != null)
            {
                txtAccountStaff.Text = staffInfo.Account;
                txtIdStaff.Text = staffInfo.IdStaff;
                txtNameStaff.Text = staffInfo.NameStaff;
                txtPhoneStaff.Text = staffInfo.PhoneNum;
                txtPositionStaff.Text = staffInfo.Position;
                idStaff = staffInfo.IdStaff;
            }
        }

        private void TrangChuST_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void bntDangKyVip_Click(object sender, EventArgs e)
        {
            DangKyVIP dk = new DangKyVIP(userPresent, passPresent, accessPresent);
            dk.Show();
            this.Hide();
        }

        private void bntXemCaLam_Click(object sender, EventArgs e)
        {
            XemCaLam xemCaLam = new XemCaLam(userPresent, passPresent, accessPresent);
            xemCaLam.Show();
            this.Hide();
        }

        private void bntQuanLyBan_Click(object sender, EventArgs e)
        {
            QuanLyBan quanLyBan = new QuanLyBan(userPre, idStaff);
            quanLyBan.Show();
            this.Hide();
        }

        private void bntThanhToan_Click(object sender, EventArgs e)
        {
            ThanhToan thanhToan = new ThanhToan(userPre, idStaff);
            thanhToan.Show();
            this.Hide();
        }
    }
}
