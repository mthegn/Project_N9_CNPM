using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BUS_HoaDon
    {
        public DTO_ChiTietHD CalculateBill(DateTime end, string idStaff, string classify, string idTable)
        {
            DAL_BillBasic dAL_BillBasic = new DAL_BillBasic();
            DTO_HoaDon hd = dAL_BillBasic.CreateBill(idStaff, end);

            DAL_HoaDon dAL_HoaDon = new DAL_HoaDon();
            return dAL_HoaDon.CalculateBill_DAL(hd.ID, end, idStaff, classify, idTable);
        }

        public DataTable GetRevenueByYear_BUS(int year)
        {
            DAL_HoaDon dAL_HoaDon = new DAL_HoaDon();
            return dAL_HoaDon.GetRevenueByYear_DAL(year);
        }

        public DataTable GetRevenueByMonth_BUS(int year, int month)
        {
            DAL_HoaDon dAL_HoaDon = new DAL_HoaDon();
            return dAL_HoaDon.GetRevenueByMonth_DAL(year, month);
        }
    }
}
