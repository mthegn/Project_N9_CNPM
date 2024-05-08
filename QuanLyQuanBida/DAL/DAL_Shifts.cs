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
    public class DAL_Shifts : ConnectDAL
    {
        public static void UpdateShift_DAL(string shift, int month, int week, string idStaff, DateTime time)
        {
            using (SqlConnection conn = Connect())
            {
                conn.Open();

                SqlCommand command = new SqlCommand("PROC_UPDATESHIFT", conn);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@SHIFT", shift);
                command.Parameters.AddWithValue("@MONTH", month);
                command.Parameters.AddWithValue("@WEEK", week);
                command.Parameters.AddWithValue("@IDSTAFF", idStaff);
                command.Parameters.AddWithValue("@TIME", time.Date);

                command.ExecuteNonQuery();
            }
        }

        public static void CreateShift_DAL(int month, int week, string idStaff, DateTime time, string shift)
        {
            using (SqlConnection conn = Connect())
            {
                conn.Open();

                SqlCommand command = new SqlCommand("CreateShift", conn);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@MONTH", month);
                command.Parameters.AddWithValue("@WEEK", week);
                command.Parameters.AddWithValue("@IDSTAFF", idStaff);
                command.Parameters.AddWithValue("@TIME", time.Date);
                command.Parameters.AddWithValue("@SHIFT", shift);

                command.ExecuteNonQuery();
            }
        }

        public static string GetStaffShift_DAL(string shift, int month, int week)
        {
            SqlConnection conn = Connect();
            conn.Open();

            SqlCommand command = new SqlCommand("PROC_GETSTAFFSHIFT", conn);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@SHIFT", shift);
            command.Parameters.AddWithValue("@MONTH", month);
            command.Parameters.AddWithValue("@WEEK", week);


            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                string idShiftGet = reader.GetString(0);

                reader.Close();
                conn.Close();
                return idShiftGet;
            }

            reader.Close();
            conn.Close();
            return null;
        }

        public static bool CheckShift_DAL(string idShift)
        {
            SqlConnection conn = Connect();
            conn.Open();

            SqlCommand command = new SqlCommand("PROC_CHECKIDSHIFT", conn);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@IDSHIFT", idShift);



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

        public static List<DTO_Shifts> GetShiftOfStaffList_DAL(string user, int month, int week)
        {
            List<DTO_Shifts> shiftList = new List<DTO_Shifts>();

            using (SqlConnection conn = Connect())
            {
                conn.Open();

                using (SqlCommand command = new SqlCommand("PROC_GETSHIFTOFSTAFF", conn))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@USER", SqlDbType.VarChar, 10).Value = user;
                    command.Parameters.Add("@MONTH", SqlDbType.Int).Value = month;
                    command.Parameters.Add("@WEEK", SqlDbType.Int).Value = week;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string idShift = reader.GetString(0);
                            DateTime timeLine = reader.GetDateTime(1);
                            DateTime dateOnly = timeLine.Date;
                            int shift = reader.GetInt32(2);
                            int weekGet = reader.GetInt32(3);
                            int monthGet = reader.GetInt32(4);

                            DTO_Shifts userInfo = new DTO_Shifts(idShift, dateOnly, shift, weekGet, monthGet);
                            shiftList.Add(userInfo);
                        }
                    }
                }
            }

            return shiftList;
        }

        public static int CalculateSalary_DAL(int month, string idStaff, int salaryPerShift)
        {
            int totalSalary = 0;

            using (SqlConnection conn = Connect())
            {
                conn.Open();

                using (SqlCommand command = new SqlCommand("CalculateSalary", conn))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@MONTH", month);
                    command.Parameters.AddWithValue("@IDSTAFF", idStaff);
                    command.Parameters.AddWithValue("@SALARY", salaryPerShift);
                    command.Parameters.Add("@TotalSalary", SqlDbType.Int).Direction = ParameterDirection.Output;

                    command.ExecuteNonQuery();

                    totalSalary = Convert.ToInt32(command.Parameters["@TotalSalary"].Value);
                }
            }

            return totalSalary;
        }
    }
}
