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
    public partial class QuanLyBan : Form
    {
        DTO_Users userPre;
        DTO_Staff staffPre;
        BUS_Tables BUS_Tables;
        BUS_SetTable BUS_SetTable;
        string idPre;
        public QuanLyBan(DTO_Users userPre, string idStaff)
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

        private void QuanLyBan_Load(object sender, EventArgs e)
        {
            Load_Form();
        }

        public void Load_Form()
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
                    string buttonDat = "btnDat" + tableNumber;
                    string buttonReset = "btnReset" + tableNumber;



                    UpdateTable(groupBox, tableNumber, textBoxId, loaiBan, tinhTrang);

                    TextBox txtBoxTinhTrang = Controls.Find(tinhTrang, true).FirstOrDefault() as TextBox;
                    Button butDat = Controls.Find(buttonDat, true).FirstOrDefault() as Button;
                    Button butReset = Controls.Find(buttonReset, true).FirstOrDefault() as Button;

                    if (txtBoxTinhTrang.Text == "Booked")
                    {
                        butDat.Hide();
                        butReset.Show();
                    }
                    else if (txtBoxTinhTrang.Text == "Empty")
                    {
                        butDat.Show();
                        butReset.Hide();
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

        private void QuanLyBan_FormClosed(object sender, FormClosedEventArgs e)
        {
            TrangChuST trangChuST = new TrangChuST(userPre.User, userPre.Pass, userPre.IdAccess);
            trangChuST.Show();
            this.Hide();
        }

        private void btnDat1_Click(object sender, EventArgs e)
        {
            DatBan db = new DatBan("1", staffPre, idPre, userPre);
            db.Show();
            this.Hide();
        }

        private void btnDat2_Click(object sender, EventArgs e)
        {
            DatBan db = new DatBan("2", staffPre, idPre, userPre);
            db.Show();
            this.Hide();
        }

        private void btnDat3_Click(object sender, EventArgs e)
        {
            DatBan db = new DatBan("3", staffPre, idPre, userPre);
            db.Show();
            this.Hide();
        }

        private void btnDat4_Click(object sender, EventArgs e)
        {
            DatBan db = new DatBan("4", staffPre, idPre, userPre);
            db.Show();
            this.Hide();
        }

        private void btnDat5_Click(object sender, EventArgs e)
        {
            DatBan db = new DatBan("5", staffPre, idPre, userPre);
            db.Show();
            this.Hide();
        }

        private void btnDat6_Click(object sender, EventArgs e)
        {
            DatBan db = new DatBan("6", staffPre, idPre, userPre);
            db.Show();
            this.Hide();
        }

        private void btnDat7_Click(object sender, EventArgs e)
        {
            DatBan db = new DatBan("7", staffPre, idPre, userPre);
            db.Show();
            this.Hide();
        }

        private void btnDat8_Click(object sender, EventArgs e)
        {
            DatBan db = new DatBan("8", staffPre, idPre, userPre);
            db.Show();
            this.Hide();
        }

        private void btnDat9_Click(object sender, EventArgs e)
        {
            DatBan db = new DatBan("9", staffPre, idPre, userPre);
            db.Show();
            this.Hide();
        }

        private void btnDat10_Click(object sender, EventArgs e)
        {
            DatBan db = new DatBan("10", staffPre, idPre, userPre);
            db.Show();
            this.Hide();
        }

        private void btnDat11_Click(object sender, EventArgs e)
        {
            DatBan db = new DatBan("11", staffPre, idPre, userPre);
            db.Show();
            this.Hide();
        }

        private void btnDat12_Click(object sender, EventArgs e)
        {
            DatBan db = new DatBan("12", staffPre, idPre, userPre);
            db.Show();
            this.Hide();
        }

        private void btnDat13_Click(object sender, EventArgs e)
        {
            DatBan db = new DatBan("13", staffPre, idPre, userPre);
            db.Show();
            this.Hide();
        }

        private void btnDat14_Click(object sender, EventArgs e)
        {
            DatBan db = new DatBan("14", staffPre, idPre, userPre);
            db.Show();
            this.Hide();
        }

        private void btnDat15_Click(object sender, EventArgs e)
        {
            DatBan db = new DatBan("15", staffPre, idPre, userPre);
            db.Show();
            this.Hide();
        }

        private void btnReset1_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Are you sure you want to Reset?", "Yes", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                BUS_SetTable.Reset_BUS("1");
                Load_Form();
            }
        }

        private void btnReset2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Reset?", "Yes", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                BUS_SetTable.Reset_BUS("2");
                Load_Form();
            }
        }

        private void btnReset3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Reset?", "Yes", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                BUS_SetTable.Reset_BUS("3");
                Load_Form();
            }
        }

        private void btnReset4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Reset?", "Yes", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                BUS_SetTable.Reset_BUS("4");
                Load_Form();
            }
        }

        private void btnReset5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Reset?", "Yes", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                BUS_SetTable.Reset_BUS("5");
                Load_Form();
            }
        }

        private void btnReset6_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Reset?", "Yes", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                BUS_SetTable.Reset_BUS("6");
                Load_Form();
            }
        }

        private void btnReset7_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Reset?", "Yes", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                BUS_SetTable.Reset_BUS("7");
                Load_Form();
            }
        }

        private void btnReset8_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Reset?", "Yes", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                BUS_SetTable.Reset_BUS("8");
                Load_Form();
            }
        }

        private void btnReset9_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Reset?", "Yes", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                BUS_SetTable.Reset_BUS("9");
                Load_Form();
            }
        }

        private void btnReset10_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Reset?", "Yes", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                BUS_SetTable.Reset_BUS("10");
                Load_Form();
            }
        }

        private void btnReset11_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Reset?", "Yes", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                BUS_SetTable.Reset_BUS("11");
                Load_Form();
            }
        }

        private void btnReset12_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Reset?", "Yes", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                BUS_SetTable.Reset_BUS("12");
                Load_Form();
            }
        }

        private void btnReset13_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Reset?", "Yes", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                BUS_SetTable.Reset_BUS("13");
                Load_Form();
            }
        }

        private void btnReset14_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Reset?", "Yes", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                BUS_SetTable.Reset_BUS("14");
                Load_Form();
            }
        }

        private void btnReset15_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Reset?", "Yes", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                BUS_SetTable.Reset_BUS("15");
                Load_Form();
            }
        }
    }
}
