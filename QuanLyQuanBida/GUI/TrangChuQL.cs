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
    public partial class TrangChuQL : Form
    {
        DTO_Users userPre;
        DTO_Staff staff;
        private string userPresent;
        private string passPresent;
        private int accessPresent;
        BUS_Staff bus;
        public TrangChuQL(string user, string pass, int idAccess)
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

        private void TrangChuQL_Load(object sender, EventArgs e)
        {
            DTO_Staff staffInfo = bus.GetStaffInfo_BUS(staff);

            if (staffInfo != null)
            {
                txtAccountStaff.Text = staffInfo.Account;
                txtIdStaff.Text = staffInfo.IdStaff;
                txtNameStaff.Text = staffInfo.NameStaff;
                txtPhoneStaff.Text = staffInfo.PhoneNum;
                txtPositionStaff.Text = staffInfo.Position;
            }
        }

        private void TrangChuQL_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void bntQuanLyNhanVien_Click(object sender, EventArgs e)
        {
            QuanLyNV quanLyNhanVien = new QuanLyNV(userPre);
            quanLyNhanVien.Show();
            this.Hide();
        }

        private void bntPhanCongCaLam_Click(object sender, EventArgs e)
        {
            PhanCongCaLam phanCong = new PhanCongCaLam(userPresent, passPresent, accessPresent, 0, 0);
            phanCong.Show();
            this.Hide();
        }

        private void bntThanhToanLuong_Click(object sender, EventArgs e)
        {
            ThanhToanLuong thanhToan = new ThanhToanLuong(userPresent, passPresent, accessPresent);
            thanhToan.Show();
            this.Hide();
        }

        private void bntThongKeDoanhThu_Click(object sender, EventArgs e)
        {
            ThongKe thongKe = new ThongKe(userPresent, passPresent, accessPresent);
            thongKe.Show();
            this.Hide();
        }
    }
}
