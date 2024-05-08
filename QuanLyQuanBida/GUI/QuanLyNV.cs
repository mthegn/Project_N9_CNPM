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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GUI
{
    public partial class QuanLyNV : Form
    {
        DTO_Users userPre;
        DTO_Staff staff;
        BUS_Staff busStaff;

        public QuanLyNV(DTO_Users userPre)
        {
            InitializeComponent();

            staff = new DTO_Staff();
            this.userPre = new DTO_Users();
            busStaff = new BUS_Staff();

            this.userPre = userPre;
            staff.Account = this.userPre.User;
        }

        private void QuanLyNV_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void LoadForm()
        {
            List<DTO_Staff> listStaff = busStaff.GetStaffList();

            dgvDanhSachNhanVien.ColumnCount = 5;

            dgvDanhSachNhanVien.Columns[0].Name = "Mã số";
            dgvDanhSachNhanVien.Columns[1].Name = "Tài khoản";
            dgvDanhSachNhanVien.Columns[2].Name = "Họ tên";
            dgvDanhSachNhanVien.Columns[3].Name = "Phone";
            dgvDanhSachNhanVien.Columns[4].Name = "Chức vụ";

            dgvDanhSachNhanVien.Rows.Clear();

            foreach (DTO_Staff temp in listStaff)
            {
                dgvDanhSachNhanVien.Rows.Add(temp.IdStaff, temp.Account, temp.NameStaff, temp.PhoneNum, temp.Position);
            }

            txtName.Text = "";
            txtAccount.Text = "";
            txtPhone.Text = "";
            txtId.Text = "";
        }

        private void bntBack_Click(object sender, EventArgs e)
        {
            TrangChuQL trangChuQL = new TrangChuQL(userPre.User, userPre.Pass, userPre.IdAccess);
            trangChuQL.Show();
            this.Hide();
        }

        private void QuanLyNV_FormClosed(object sender, FormClosedEventArgs e)
        {
            TrangChuQL trangChuQL = new TrangChuQL(userPre.User, userPre.Pass, userPre.IdAccess);
            trangChuQL.Show();
            this.Hide();
        }

        private void bntThem_Click(object sender, EventArgs e)
        {
            string nameStaff = txtName.Text;
            string phone = txtPhone.Text;
            string account = txtAccount.Text;
            if (phone == "" & account == "")
            {
                MessageBox.Show("Add new staff false. Please, enter all infomation.");
            } else
            {
                DTO_Staff temp = new DTO_Staff(nameStaff, phone, account);
                if (busStaff.AddStaff_Bus(temp))
                {
                    busStaff.AddStaff_Bus(temp);
                    MessageBox.Show("Add new staff successfull!");
                }
                else
                {
                    MessageBox.Show("Add new staff false.");
                }
                LoadForm();
            }
        }

        private void bntSua_Click(object sender, EventArgs e)
        {
            string nameStaff = txtName.Text;
            string phone = txtPhone.Text;
            string account = txtAccount.Text;
            string idStaff = txtId.Text;
                    
            if (idStaff == "")
            {
                MessageBox.Show("ID staff null. Please, enter ID staff to change.");
            }
            else
            {
                DTO_Staff newStaff = new DTO_Staff(nameStaff, phone, account, idStaff);
                DTO_Staff preStaff = busStaff.GetStaffById_BUS(newStaff);
                if (preStaff == null)
                {
                    MessageBox.Show("ID staff incorrect.");
                } else
                {
                    if (preStaff.NameStaff == nameStaff && preStaff.PhoneNum == phone)
                    {
                        MessageBox.Show("Everything is still the same, nothing has changed.");
                    }
                    else
                    {
                        if (busStaff.ChangeStaff_BUS(newStaff))
                        {
                            busStaff.ChangeStaff_BUS(newStaff);
                            MessageBox.Show("Change infomation of staff successful!");
                            LoadForm();
                        }
                        else
                        {
                            MessageBox.Show("Id staff wrong. Please, enter correcting id staff.");
                        }
                    }
                }
            }
        }

        private void bntXoa_Click(object sender, EventArgs e)
        {
            string nameStaff = txtName.Text;
            string phone = txtPhone.Text;
            string account = txtAccount.Text;
            string idStaff = txtId.Text;

            DTO_Staff newStaff = new DTO_Staff(nameStaff, phone, account, idStaff);
            if (newStaff.IdStaff == "")
            {
                MessageBox.Show("ID staff null. Please, enter ID staff to delete.");
            } else
            {
                if (busStaff.DeleteStaff_BUS(newStaff))
                {
                    busStaff.DeleteStaff_BUS(newStaff);
                    MessageBox.Show("Delete staff successful!");
                    LoadForm();
                }
                else
                {
                    MessageBox.Show("Id staff wrong. Please, enter correcting id staff.");
                }
            }
        }
    }
}
