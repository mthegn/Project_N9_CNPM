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
    public class DAL_VIP : ConnectDAL
    {
        public static bool CreateVIP_DAL(DTO_VIP vip)
        {
            Connect();
            conn.Open();
            bool result = false;

            SqlCommand command = new SqlCommand("PROC_CREATEVIP", conn);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@NAME", vip.Name);
            command.Parameters.AddWithValue("@PHONE", vip.Phone);

            SqlParameter resultParam = new SqlParameter("@RESULT", SqlDbType.Bit);
            resultParam.Direction = ParameterDirection.Output;
            command.Parameters.Add(resultParam);

            command.ExecuteNonQuery();

            result = Convert.ToBoolean(resultParam.Value);


            conn.Close();
            return result;
        }

        public static bool CheckPhoneVIP_DAL(string phoneNum)
        {
            SqlConnection conn = Connect();
            conn.Open();

            SqlCommand command = new SqlCommand("PROC_CheckVIP", conn);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@PHONENUM", phoneNum);

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
    }
}
