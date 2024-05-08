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

namespace GUI
{
    public partial class ThanhToanLuong : Form
    {
        BUS_Shifts BUS_Shifts;
        BUS_Staff BUS_Staff;
        DTO_Staff staff;
        string userPre;
        string passPre;
        int accessPre;
        public ThanhToanLuong(string user, string pass, int access)
        {
            InitializeComponent();
            BUS_Shifts = new BUS_Shifts();
            staff = new DTO_Staff();
            BUS_Staff = new BUS_Staff();
            userPre = user;
            passPre = pass;
            accessPre = access;
            DTO_Staff temp = new DTO_Staff();
            temp.Account = userPre;
            staff = BUS_Staff.GetStaffInfo_BUS(temp);
        }

        private void btnCalPrint_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các điều khiển trong giao diện
            int month = 0;
            if (cbbThang.SelectedItem != null && int.TryParse(cbbThang.SelectedItem.ToString(), out int parsedResult))
            {
                month = parsedResult;
            }
            string idStaff = cbbIDStaff.SelectedItem.ToString(); 
            int salaryPerShift = 0;
            if (int.TryParse(txtLuongTheoCa.Text, out int result))
            {
                salaryPerShift = result;
            }
            DTO_Staff tmp = new DTO_Staff();
            tmp.IdStaff = idStaff;
            DTO_Staff staffSal = new DTO_Staff();
            staffSal = BUS_Staff.GetStaffById_BUS(tmp);

            // Kiểm tra các thông tin có hợp lệ hay không
            if (month == 0 || string.IsNullOrEmpty(idStaff) || salaryPerShift == 0)
            {
                MessageBox.Show("Please enter all information!");
                return;
            }

            // Tính toán lương
            int salary = BUS_Shifts.CalculateSalary_BUS(month, idStaff, salaryPerShift);

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
                    worksheet.Cells[3, 1].Value = "THANH TOÁN LƯƠNG";

                    worksheet.Cells[4, 1] = "Mã nhân viên:";
                    worksheet.Cells[4, 2] = idStaff;

                    worksheet.Cells[5, 1] = "Tên nhân viên:";
                    worksheet.Cells[5, 2] = staffSal.NameStaff;

                    worksheet.Cells[6, 1] = "Chức vụ:";
                    worksheet.Cells[6, 2] = "Staff";

                    worksheet.Cells[7, 1] = "Số điện thoại";
                    worksheet.Cells[7, 2].NumberFormat = "@";
                    worksheet.Cells[7, 2].Value = "'" + staffSal.PhoneNum;

                    worksheet.Cells[8, 1] = "Lương tháng";
                    worksheet.Cells[8, 2].NumberFormat = "@";
                    worksheet.Cells[8, 2].Value = "'" + salary.ToString();

                    // Căn chỉnh căn giữa cho các ô
                    Range range = worksheet.Range["A1:B2"];
                    range.HorizontalAlignment = XlHAlign.xlHAlignLeft;
                    range.VerticalAlignment = XlVAlign.xlVAlignCenter;

                    Range titleRange = worksheet.Range[worksheet.Cells[3, 1], worksheet.Cells[3, 2]];
                    titleRange.Merge();
                    titleRange.Font.Bold = true;
                    titleRange.Font.Color = Color.Black;
                    titleRange.HorizontalAlignment = XlHAlign.xlHAlignCenter;

                    // Căn độ rộng cột
                    Range columns = worksheet.UsedRange.Columns;
                    columns.AutoFit();

                    // Lưu tệp Excel
                    workbook.SaveAs(fileName);

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

        private void btnHuy_Click(object sender, EventArgs e)
        {
            TrangChuQL trangChu = new TrangChuQL(userPre, passPre, accessPre);
            trangChu.Show();
            this.Hide();
        }

        private void ThanhToanLuong_FormClosed(object sender, FormClosedEventArgs e)
        {
            TrangChuQL trangChu = new TrangChuQL(userPre, passPre, accessPre);
            trangChu.Show();
            this.Hide();
        }

        private void ThanhToanLuong_Load(object sender, EventArgs e)
        {
            List<string> idList = BUS_Staff.GetListID_BUS();

            foreach (string s in idList)
            {
                if (s == "NV0001")
                {
                    continue;
                }
                cbbIDStaff.Items.Add(s);
            }
        }
    }
}
