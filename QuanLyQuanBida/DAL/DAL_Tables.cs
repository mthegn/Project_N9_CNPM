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
    public class DAL_Tables : ConnectDAL
    {
        public static DTO_Tables GetTableList_DAL(string idTable)
        {
            DTO_Tables tableInfo = new DTO_Tables();

            SqlConnection conn = Connect();
            conn.Open();

            SqlCommand command = new SqlCommand("PROC_GETTABLE", conn);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@IDTABLE", idTable);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string idTableGet = reader.GetString(0);
                string classify = reader.GetString(1);
                string situation = reader.GetString(2);

                tableInfo = new DTO_Tables(idTableGet, classify, situation);
            }

            reader.Close();
            conn.Close();

            return tableInfo;
        }
    }
}
