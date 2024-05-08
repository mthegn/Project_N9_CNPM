using DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Staff : ConnectDAL
    {
        // Get Information of staff 1 person
        public static DTO_Staff GetStaffInfo_DAL(DTO_Staff stf)
        {
            SqlConnection conn = Connect();
            conn.Open();

            SqlCommand command = new SqlCommand("PROC_GETSTAFFINFO", conn);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@ACCOUNT", stf.Account);

            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                string idStaff = reader.GetString(0);
                string account = reader.GetString(1);
                string name = reader.GetString(2);
                string phone = reader.GetString(3);
                string pos = reader.GetString(4);

                DTO_Staff userInfo = new DTO_Staff(idStaff, account, name, phone, pos);

                reader.Close();
                conn.Close();
                return userInfo;
            }

            reader.Close();
            conn.Close();
            return null;
        }

        public static DTO_Staff GetStaffInfoById_DAL(DTO_Staff stf)
        {
            SqlConnection conn = Connect();
            conn.Open();

            SqlCommand command = new SqlCommand("PROC_GETSTAFFINFOBYID", conn);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@IDSTAFF", stf.IdStaff);

            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                string name = reader.GetString(0);
                string phone = reader.GetString(1);
                string account = reader.GetString(2);

                DTO_Staff userInfo = new DTO_Staff(name, phone, account);

                reader.Close();
                conn.Close();
                return userInfo;
            }

            reader.Close();
            conn.Close();
            return null;
        }

        // get list
        public static List<DTO_Staff> GetStaffInfoList_DAL()
        {
            List<DTO_Staff> staffList = new List<DTO_Staff>();

            SqlConnection conn = Connect();
            conn.Open();

            SqlCommand command = new SqlCommand("PROC_GETLISTSTAFF", conn);
            command.CommandType = CommandType.StoredProcedure;


            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string idStaff = reader.GetString(0);
                string account;
                if (reader.IsDBNull(1))
                {
                    account = "";
                }
                else {
                    account = reader.GetString(1);
                }
                string name = reader.GetString(2);
                string phone = reader.GetString(3);
                string pos = reader.GetString(4);

                DTO_Staff userInfo = new DTO_Staff(idStaff, account, name, phone, pos);
                staffList.Add(userInfo);
            }

            reader.Close();
            conn.Close();

            return staffList;
        }

        public static bool CheckStaff_DAL(string idStaff)
        {
            SqlConnection conn = Connect();
            conn.Open();

            SqlCommand command = new SqlCommand("PROC_CHECKSTAFFSHIFT", conn);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@IDSTAFF", idStaff);

            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Close();
                conn.Close();
                return true;
            }

            reader.Close();
            conn.Close();
            return false;
        }

        public static bool CheckAccount_DAL(string account)
        {
            SqlConnection conn = Connect();
            conn.Open();

            SqlCommand command = new SqlCommand("PROC_CHECKACCOUNT", conn);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@ACCOUNT", account);

            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Close();
                conn.Close();
                return true;
            }

            reader.Close();
            conn.Close();
            return false;
        }

        public static void AddStaff_DAL(DTO_Staff staff)
        {
            using (SqlConnection conn = ConnectDAL.Connect())
            {
                conn.Open();

                SqlCommand command = new SqlCommand("PROC_ADDNEWSTAFF", conn);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@NAME", staff.NameStaff);
                command.Parameters.AddWithValue("@PHONENUM", staff.PhoneNum);
                command.Parameters.AddWithValue("@ACCOUNT", staff.Account);

                command.ExecuteNonQuery();
            }
        }

        public static void CreateAccount_DAL(DTO_Staff staff)
        {
            using (SqlConnection conn = ConnectDAL.Connect())
            {
                conn.Open();

                SqlCommand command = new SqlCommand("PROC_CREATENEWACCOUNT", conn);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@ACCOUNT", staff.Account);

                command.ExecuteNonQuery();
            }
        }

        public static void ChangeStaff_DAL(DTO_Staff staff)
        {
            using (SqlConnection conn = ConnectDAL.Connect())
            {
                conn.Open();

                SqlCommand command = new SqlCommand("PROC_CHANGESTAFF", conn);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@NAME", staff.NameStaff);
                command.Parameters.AddWithValue("@PHONENUM", staff.PhoneNum);
                command.Parameters.AddWithValue("@IDSTAFF", staff.IdStaff);

                command.ExecuteNonQuery();
            }
        }

        public static void DeleteStaff_DAL(DTO_Staff staff)
        {
            using (SqlConnection conn = ConnectDAL.Connect())
            {
                conn.Open();

                SqlCommand command = new SqlCommand("PROC_DELETESTAFF", conn);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@IDSTAFF", staff.IdStaff);

                command.ExecuteNonQuery();
            }
        }

        public static List<string> GetListID_DAL()
        {
            List<string> idList = new List<string>();

            SqlConnection conn = Connect();
            conn.Open();

            SqlCommand command = new SqlCommand("PROC_GETLISTSTAFF", conn);
            command.CommandType = CommandType.StoredProcedure;

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string idStaff = reader.GetString(0);
                idList.Add(idStaff);
            }

            reader.Close();
            conn.Close();

            return idList;
        }
    }
}
