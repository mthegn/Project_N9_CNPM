using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;


namespace GUI
{
    public partial class ThongKe : Form
    {
        private string userPre;
        private string passPre;
        private int accPre;
        BUS_HoaDon BUS_HoaDon;
        DataTable dataTable;
        public ThongKe(string user, string pass, int idAccess)
        {
            InitializeComponent();
            BUS_HoaDon = new BUS_HoaDon();

            userPre = user;
            passPre = pass;
            accPre = idAccess;
        }

        private void btnThongKeNam_Click(object sender, EventArgs e)
        {
            int year = int.Parse(txtYear.Text);
            dataTable = new DataTable();
            dataTable = BUS_HoaDon.GetRevenueByYear_BUS(year);
            dtgvThongKe.DataSource = dataTable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TrangChuQL trangChu = new TrangChuQL(userPre, passPre, accPre);
            trangChu.Show();
            this.Hide();
        }

        private void btnThongKeThang_Click(object sender, EventArgs e)
        {
            int year = int.Parse(txtYear.Text);
            if ( cbbMonth.SelectedIndex == -1)
            {
                MessageBox.Show("Please, choose a month which you want to get revenue.");
            } else
            {
                int month = int.Parse(cbbMonth.SelectedItem.ToString());
                dataTable = new DataTable();
                dataTable = BUS_HoaDon.GetRevenueByMonth_BUS(year, month);
                dtgvThongKe.DataSource = dataTable;
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx";
            saveFileDialog.Title = "Save Excel File";

            // Hiển thị cửa sổ lưu tệp
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                try
                {
                    // Tạo đối tượng Excel
                    Excel.Application excel = new Excel.Application();
                    excel.Visible = false;
                    excel.DisplayAlerts = false;

                    Excel.Workbook workbook = excel.Workbooks.Add(Type.Missing);
                    Excel.Worksheet worksheet = (Excel.Worksheet)workbook.ActiveSheet;

                    // Ghi dữ liệu từ DataTable vào Excel
                    int rowCount = dataTable.Rows.Count;
                    int columnCount = dataTable.Columns.Count;

                    worksheet.Cells[1, 1] = "MIN Billiard Club";
                    worksheet.Cells[2, 1] = "Min billiards Toà a4 Hàm nghi, Nam Từ Liêm - Hà Nội";
                    worksheet.Cells[3, 1].Value = "THỐNG KÊ DOANH THU";

                    // Ghi tiêu đề cột
                    string[] columnName = {"Tháng", "Doanh thu" };
                    for (int i = 0; i < columnCount; i++)
                    {
                        worksheet.Cells[4, i + 1] = columnName[i];
                    }

                    // Ghi dữ liệu
                    for (int row = 0; row < rowCount; row++)
                    {
                        for (int col = 0; col < columnCount; col++)
                        {
                            worksheet.Cells[row + 5, col + 1] = dataTable.Rows[row][col];
                        }
                    }

                    // Căn chỉnh
                    Excel.Range columns = worksheet.UsedRange.Columns;
                    columns.AutoFit();

                    Excel.Range range = worksheet.Range["A1:B2"];
                    range.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
                    range.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;

                    Excel.Range titleRange = worksheet.Range[worksheet.Cells[3, 1], worksheet.Cells[3, 2]];
                    titleRange.Merge();
                    titleRange.Font.Bold = true;
                    titleRange.Font.Color = Color.Black;
                    titleRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                    Excel.Range dataRange = worksheet.Range["A5:A17"];
                    dataRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
                    // Lưu tệp Excel
                    workbook.SaveAs(filePath);

                    workbook.Close();
                    excel.Quit();
                    MessageBox.Show("Exported data to Excel successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ThongKe_FormClosed(object sender, FormClosedEventArgs e)
        {
            TrangChuQL trangChu = new TrangChuQL(userPre, passPre, accPre);
            trangChu.Show();
            this.Hide();
        }
    }
}
