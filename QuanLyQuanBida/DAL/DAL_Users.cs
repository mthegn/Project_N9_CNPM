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
    public class DAL_Users : ConnectDAL
    {
        // Check login
        public static bool CheckLogin_DAL(string user, string pass)
        {
            bool result = false;

            using (SqlConnection conn = Connect())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("PROC_CHECKLOGIN", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ACC", user);
                cmd.Parameters.AddWithValue("@PASS", pass);

                SqlParameter resultParam = new SqlParameter("@RESULT", SqlDbType.Bit);
                resultParam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(resultParam);

                cmd.ExecuteNonQuery();

                result = (bool)resultParam.Value;
            }

            return result;
        }

        // Change password
        public static void ChangePass_DAL(string user, string newPass)
        {
            using (SqlConnection conn = ConnectDAL.Connect())
            {
                conn.Open();

                SqlCommand command = new SqlCommand("PROC_CHANGEPASS", conn);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@ACC", user);
                command.Parameters.AddWithValue("@NEWPASS", newPass);

                command.ExecuteNonQuery();
            }
        }

        // Get Information of account
        public static DTO_Users GetUserInfo_DAL(DTO_Users user)
        {
            SqlConnection conn = Connect();
            conn.Open();

            SqlCommand command = new SqlCommand("PROC_GETUSERIFNOMATION", conn);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@Username", user.User);

            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                string userName = reader.GetString(0);
                string pass = reader.GetString(1);
                int idAccess = reader.GetInt32(2);

                user = new DTO_Users(userName, pass, idAccess);

                reader.Close();
                conn.Close();
                return user;
            }

            reader.Close();
            conn.Close();
            return null;
        }
    }
}
