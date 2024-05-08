using BLL;
using DTO;
using Microsoft.Office.Interop.Excel;
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
    public partial class XacNhanThanhToan : Form
    {
        private string idStaffToCalculate;
        private string classifyToCalculate;
        private string idTableToCalculate;
        DTO_Users user;
        BUS_HoaDon BUS_HoaDon;
        public XacNhanThanhToan(string idStaff, string classify, string idTable, DTO_Users userPre)
        {
            InitializeComponent();
            BUS_HoaDon = new BUS_HoaDon();
            user = new DTO_Users();
            user = userPre;
            idStaffToCalculate = idStaff;
            classifyToCalculate = classify;
            idTableToCalculate = idTable;
        }

        private void bntXacNhan_Click(object sender, EventArgs e)
        {
            DateTime dateTime = dtpEndTime.Value;

            DTO_ChiTietHD hoaDon = BUS_HoaDon.CalculateBill(dateTime, idStaffToCalculate, classifyToCalculate, idTableToCalculate);

            MessageBox.Show("Total cost: " + hoaDon.Price.ToString());
            // Tạo đối tượng SaveFileDialog
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx";
            saveFileDialog.Title = "Save Excel File";

            // Hiển thị cửa sổ lưu tệp
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;

                try
                {
                    // Tạo đối tượng Excel
                    Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                    excel.Visible = false;
                    excel.DisplayAlerts = false;

                    Workbook workbook = excel.Workbooks.Add(Type.Missing);
                    Worksheet worksheet = (Worksheet)workbook.Sheets["Sheet1"];

                    // Ghi dữ liệu vào tệp Excel
                    worksheet.Cells[1, 1] = "MIN Billiard Club";
                    worksheet.Cells[2, 1] = "Min billiards Toà a4 Hàm nghi, Nam Từ Liêm - Hà Nội";
                    worksheet.Cells[3, 1].Value = "HÓA ĐƠN THANH TOÁN";

                    worksheet.Cells[4, 1] = "Mã hóa đơn:";
                    worksheet.Cells[4, 2] = hoaDon.ID;

                    worksheet.Cells[5, 1] = "Mã bàn:";
                    worksheet.Cells[5, 2] = hoaDon.IdTable;

                    worksheet.Cells[6, 1] = "Thời gian bắt đầu:";
                    worksheet.Cells[6, 2] = hoaDon.BeginAt;

                    worksheet.Cells[7, 1] = "Thời gian kết thúc";
                    worksheet.Cells[7, 2] = hoaDon.FinishAt;


                    worksheet.Cells[8, 1] = "Tên khách hàng:";
                    worksheet.Cells[8, 2] = hoaDon.NameCus;

                    worksheet.Cells[9, 1] = "Số điện thoại khách:";
                    worksheet.Cells[9, 2].NumberFormat = "@";
                    worksheet.Cells[9, 2].Value = "'" + hoaDon.PhoneNum;

                    worksheet.Cells[10, 1] = "Tổng tiền:";
                    worksheet.Cells[10, 2] = hoaDon.Price;

                    // Căn chỉnh căn giữa cho các ô
                    Range range = worksheet.Range["A1:B2"];
                    range.HorizontalAlignment = XlHAlign.xlHAlignLeft;
                    range.VerticalAlignment = XlVAlign.xlVAlignCenter;

                    Range titleRange = worksheet.Range[worksheet.Cells[3, 1], worksheet.Cells[3, 2]];
                    titleRange.Merge();
                    titleRange.Font.Bold = true;
                    titleRange.Font.Color = Color.Black;
                    titleRange.HorizontalAlignment = XlHAlign.xlHAlignCenter;

                    Range title = worksheet.Range[worksheet.Cells[10, 1], worksheet.Cells[10, 2]];
                    title.Font.Bold = true;
                    title.Font.Color = Color.Black;
                    // Căn độ rộng cột
                    Range columns = worksheet.UsedRange.Columns;
                    columns.AutoFit();

                    // Lưu tệp Excel
                    workbook.SaveAs(fileName);

                    workbook.Close();
                    excel.Quit();
                    MessageBox.Show("Exported data to Excel successfully!");

                    ThanhToan thanhToan = new ThanhToan(user, idStaffToCalculate);
                    thanhToan.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ThanhToan thanhToan = new ThanhToan(user, idStaffToCalculate);
            thanhToan.Show();
            this.Hide();
        }

        private void XacNhanThanhToan_FormClosed(object sender, FormClosedEventArgs e)
        {
            ThanhToan thanhToan = new ThanhToan(user, idStaffToCalculate);
            thanhToan.Show();
            this.Hide();
        }
    }
}
