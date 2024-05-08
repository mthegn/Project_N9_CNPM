using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_SetTable : ConnectDAL
    {
        public void SetTable_DAL(DTO_SetTable setTable)
        {
            using (SqlConnection conn = Connect())
            {
                conn.Open();

                SqlCommand command = new SqlCommand("PROC_REVERVETABLE", conn);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@IDTABLE", setTable.IdTable);
                command.Parameters.AddWithValue("@StartTime", setTable.TimeStart);
                command.Parameters.AddWithValue("@IDSTAFF", setTable.IdStaff);
                command.Parameters.AddWithValue("@PHONENUM", setTable.PhoneNum);

                command.ExecuteNonQuery();
            }
        }

        public void Reset_DAL(string idTable)
        {
            using (SqlConnection conn = Connect())
            {
                conn.Open();

                SqlCommand command = new SqlCommand("PROC_RESETTABLE", conn);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@IDTABLE", idTable);

                command.ExecuteNonQuery();
            }
        }
    }
}
