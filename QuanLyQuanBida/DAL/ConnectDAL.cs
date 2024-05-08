using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;
using System.Reflection;

namespace DAL
{
    public class ConnectDAL
    {
        public static SqlConnection conn;
        public static SqlConnection Connect()
        {
            string s = @"Data Source=MACBOOK-LOR;Initial Catalog=QuanLyQuanBiDa;Integrated Security=True";
            conn = new SqlConnection(s);
            return conn;
        }
    }
}
