using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_HoaDon
    {
        public DTO_HoaDon() { }

        public int ID { get; set; }
        public string IdStaff { get; set; }
        public DateTime PrintDate { get; set; }

        public DTO_HoaDon(int id, string idStaff, DateTime printDate)
        {
            ID = id;
            IdStaff = idStaff;
            PrintDate = printDate;
        }

        public DTO_HoaDon(string idStaff, DateTime printDate)
        {
            IdStaff = idStaff;
            PrintDate = printDate;
        }
    }
}
