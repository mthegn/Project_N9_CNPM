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
    public class DAL_HoaDon : ConnectDAL
    {
        public DTO_ChiTietHD CalculateBill_DAL (int id, DateTime timeEnd, string idStaff, string classify, string idTable)
        {
            SqlConnection conn = Connect();
            conn.Open();

            SqlCommand command = new SqlCommand("CalculateBill", conn);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@ID", id);
            command.Parameters.AddWithValue("@TIMEEND", timeEnd);
            command.Parameters.AddWithValue("@IDSTAFF", idStaff);
            command.Parameters.AddWithValue("@CLASSIFY", classify);
            command.Parameters.AddWithValue("@IDTABLE", idTable);

            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                int idBill = reader.GetInt32(0);
                string idTbl = reader.GetString(1);
                DateTime beginAt = reader.GetDateTime(2);
                DateTime finishAt = reader.GetDateTime(3);
                double price = reader.GetDouble(4);
                string phoneNum, name;
                if (!reader.IsDBNull(5))
                {
                    phoneNum = reader.GetString(5);
                }
                else
                {
                    phoneNum = "Unknown";
                }
                if (!reader.IsDBNull(6))
                {
                    name = reader.GetString(6);
                }
                else
                {
                    name = "Unknown";
                }
                DTO_ChiTietHD bill = new DTO_ChiTietHD(idBill, idTbl, beginAt, finishAt, price, phoneNum, name);

                reader.Close();
                conn.Close();
                return bill;
            }

            reader.Close();
            conn.Close();
            return null;
        }

        public DataTable GetRevenueByYear_DAL(int year)
        {
            SqlConnection conn = Connect();
            conn.Open();

            SqlCommand command = new SqlCommand("GetRevenueByYear", conn);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@Year", year);

            SqlDataReader reader = command.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(reader);

            reader.Close();
            conn.Close();

            return dataTable;
        }

        public DataTable GetRevenueByMonth_DAL(int year, int month)
        {
            SqlConnection conn = Connect();
            conn.Open();

            SqlCommand command = new SqlCommand("GetRevenueByMonth", conn);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@Year", year);
            command.Parameters.AddWithValue("@Month", month);

            SqlDataReader reader = command.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(reader);

            reader.Close();
            conn.Close();

            return dataTable;
        }
    }
}
