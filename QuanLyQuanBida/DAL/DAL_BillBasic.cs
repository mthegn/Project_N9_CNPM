using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_BillBasic : ConnectDAL
    {
        public DTO_HoaDon CreateBill(string idStaff, DateTime end)
        {
            SqlConnection conn = Connect();
            conn.Open();

            SqlCommand command = new SqlCommand("createbill", conn);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@IDSTAFF", idStaff);
            command.Parameters.AddWithValue("@PRINTDATE", end);

            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                int idBill = reader.GetInt32(0);
                string idStaffNew = reader.GetString(1);
                DateTime endTime = reader.GetDateTime(2);

                DTO_HoaDon bill = new DTO_HoaDon(idBill, idStaffNew, endTime);

                reader.Close();
                conn.Close();
                return bill;
            }

            reader.Close();
            conn.Close();
            return null;
        }
    }
}
