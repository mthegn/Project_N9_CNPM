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
    public partial class ThanhToan : Form
    {
        DTO_Users userPre;
        DTO_Staff staffPre;
        BUS_Tables BUS_Tables;
        BUS_SetTable BUS_SetTable;
        string idPre;

        public ThanhToan(DTO_Users userPre, string idStaff)
        {
            InitializeComponent();

            BUS_Tables = new BUS_Tables();
            this.userPre = new DTO_Users();
            BUS_SetTable = new BUS_SetTable();

            this.userPre = userPre;
            idPre = idStaff;
        }

        private List<TextBox> FindTextBoxesInGroupBox(GroupBox groupBox)
        {
            List<TextBox> textBoxes = new List<TextBox>();

            foreach (Control control in groupBox.Controls)
            {
                if (control is TextBox)
                {
                    textBoxes.Add((TextBox)control);
                }
            }

            return textBoxes;
        }

        private void UpdateTable(GroupBox group, string idTable, string nameTbl, string clss, string situa)
        {
            List<TextBox> list = FindTextBoxesInGroupBox(group);
            DTO_Tables tables = BUS_Tables.GetInfoTable(idTable);

            if (tables == null)
            {
                tables = new DTO_Tables();
            }
            foreach (TextBox textBox in list)
            {
                if (textBox.Name == nameTbl)
                {
                    textBox.Text = tables.IdTable;
                }
                else if (textBox.Name == clss)
                {
                    textBox.Text = tables.Classify;
                }
                else if (textBox.Name == situa)
                {
                    textBox.Text = tables.Situation;
                }
            }
        }

        private void ThanhToan_Load(object sender, EventArgs e)
        {
            int numberOfTables = 15;

            for (int i = 1; i <= numberOfTables; i++)
            {
                string tableNumber = i.ToString();
                string groupBoxName = "groupBox" + tableNumber;

                GroupBox groupBox = Controls.Find(groupBoxName, true).FirstOrDefault() as GroupBox;
                if (groupBox != null)
                {
                    string textBoxId = "txtSoBan" + tableNumber;
                    string loaiBan = "txtLoaiBan" + tableNumber;
                    string tinhTrang = "txtTinhTrang" + tableNumber;
                    string buttonDat = "btnThanhToan" + tableNumber;



                    UpdateTable(groupBox, tableNumber, textBoxId, loaiBan, tinhTrang);

                    TextBox txtBoxTinhTrang = Controls.Find(tinhTrang, true).FirstOrDefault() as TextBox;
                    Button butDat = Controls.Find(buttonDat, true).FirstOrDefault() as Button;

                    if (txtBoxTinhTrang.Text == "Booked")
                    {
                        butDat.Enabled = true;
                    }
                    else if (txtBoxTinhTrang.Text == "Empty")
                    {
                        butDat.Enabled = false;
                    }
                }
            }
        }

        private void bntBack_Click(object sender, EventArgs e)
        {
            TrangChuST trangChuST = new TrangChuST(userPre.User, userPre.Pass, userPre.IdAccess);
            trangChuST.Show();
            this.Hide();
        }

        private void ThanhToan_FormClosed(object sender, FormClosedEventArgs e)
        {
            TrangChuST trangChuST = new TrangChuST(userPre.User, userPre.Pass, userPre.IdAccess);
            trangChuST.Show();
            this.Hide();
        }

        private void btnThanhToan1_Click(object sender, EventArgs e)
        {
            XacNhanThanhToan xnThanhToan = new XacNhanThanhToan(idPre, "Pool", "1", userPre);
            xnThanhToan.Show();
            this.Hide();
        }

        private void btnThanhToan2_Click(object sender, EventArgs e)
        {
            XacNhanThanhToan xnThanhToan = new XacNhanThanhToan(idPre, "Pool", "2", userPre);
            xnThanhToan.Show();
            this.Hide();
        }

        private void btnThanhToan3_Click(object sender, EventArgs e)
        {
            XacNhanThanhToan xnThanhToan = new XacNhanThanhToan(idPre, "Pool", "3", userPre);
            xnThanhToan.Show();
            this.Hide();
        }

        private void btnThanhToan4_Click(object sender, EventArgs e)
        {
            XacNhanThanhToan xnThanhToan = new XacNhanThanhToan(idPre, "Pool", "4", userPre);
            xnThanhToan.Show();
            this.Hide();
        }

        private void btnThanhToan5_Click(object sender, EventArgs e)
        {
            XacNhanThanhToan xnThanhToan = new XacNhanThanhToan(idPre, "Pool", "5", userPre);
            xnThanhToan.Show();
            this.Hide();
        }

        private void btnThanhToan6_Click(object sender, EventArgs e)
        {
            XacNhanThanhToan xnThanhToan = new XacNhanThanhToan(idPre, "Libre", "6", userPre);
            xnThanhToan.Show();
            this.Hide();
        }

        private void btnThanhToan7_Click(object sender, EventArgs e)
        {
            XacNhanThanhToan xnThanhToan = new XacNhanThanhToan(idPre, "Libre", "7", userPre);
            xnThanhToan.Show();
            this.Hide();
        }

        private void btnThanhToan8_Click(object sender, EventArgs e)
        {
            XacNhanThanhToan xnThanhToan = new XacNhanThanhToan(idPre, "Libre", "8", userPre);
            xnThanhToan.Show();
            this.Hide();
        }

        private void btnThanhToan9_Click(object sender, EventArgs e)
        {
            XacNhanThanhToan xnThanhToan = new XacNhanThanhToan(idPre, "Libre", "9", userPre);
            xnThanhToan.Show();
            this.Hide();
        }

        private void btnThanhToan10_Click(object sender, EventArgs e)
        {
            XacNhanThanhToan xnThanhToan = new XacNhanThanhToan(idPre, "Libre", "10", userPre);
            xnThanhToan.Show();
            this.Hide();
        }

        private void btnThanhToan11_Click(object sender, EventArgs e)
        {
            XacNhanThanhToan xnThanhToan = new XacNhanThanhToan(idPre, "Carom", "11", userPre);
            xnThanhToan.Show();
            this.Hide();
        }

        private void btnThanhToan12_Click(object sender, EventArgs e)
        {
            XacNhanThanhToan xnThanhToan = new XacNhanThanhToan(idPre, "Carom", "12", userPre);
            xnThanhToan.Show();
            this.Hide();
        }

        private void btnThanhToan13_Click(object sender, EventArgs e)
        {
            XacNhanThanhToan xnThanhToan = new XacNhanThanhToan(idPre, "Carom", "13", userPre);
            xnThanhToan.Show();
            this.Hide();
        }

        private void btnThanhToan14_Click(object sender, EventArgs e)
        {
            XacNhanThanhToan xnThanhToan = new XacNhanThanhToan(idPre, "Carom", "14", userPre);
            xnThanhToan.Show();
            this.Hide();
        }

        private void btnThanhToan15_Click(object sender, EventArgs e)
        {
            XacNhanThanhToan xnThanhToan = new XacNhanThanhToan(idPre, "Carom", "15", userPre);
            xnThanhToan.Show();
            this.Hide();
        }
    }
}
