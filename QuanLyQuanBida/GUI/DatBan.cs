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
    public partial class DatBan : Form
    {
        BUS_SetTable busSetTable;
        DTO_Staff staff;
        DTO_Users userToQuanLy;
        BUS_Tables BUS_Tables;
        BUS_Staff BUS_Staff;
        string idTable;
        string idPre;

        public DatBan(string idTable, DTO_Staff staff, string idStaff, DTO_Users us)
        {
            InitializeComponent();
            busSetTable = new BUS_SetTable();
            BUS_Staff = new BUS_Staff();
            this.staff = new DTO_Staff();
            BUS_Tables = new BUS_Tables();
            userToQuanLy = new DTO_Users();

            userToQuanLy = us;
            this.staff = staff;
            this.idTable = idTable;
            idPre = idStaff;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            string phone = txtPhone.Text;

            DTO_SetTable setTable = new DTO_SetTable();
            setTable.TimeStart = dt;
            setTable.PhoneNum = phone;
            setTable.IdStaff = idPre;
            setTable.IdTable = idTable;

            if (busSetTable.SetTable_BUS(setTable))
            {
                busSetTable.SetTable_BUS(setTable);
                MessageBox.Show("Successful table booking.");
                QuanLyBan quanLyBan = new QuanLyBan(userToQuanLy, idPre);
                quanLyBan.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Table booking failed.");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            QuanLyBan quanLyBan = new QuanLyBan(userToQuanLy, idPre);
            quanLyBan.Show();
            this.Hide();
        }

        private void DatBan_FormClosed(object sender, FormClosedEventArgs e)
        {
            QuanLyBan quanLyBan = new QuanLyBan(userToQuanLy, idPre);
            quanLyBan.Show();
            this.Hide();
        }
    }
}
