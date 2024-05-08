using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_SetTable
    {
        public string IdTable { get; set; }
        public string IdStaff { get; set; }
        public DateTime TimeStart { get; set; }
        public DateTime TimeEnd { get; set; }
        public string PhoneNum { get; set; }


        public DTO_SetTable(string idTable, string idStaff, DateTime timeStart, DateTime timeEnd, string phoneNum)
        {
            IdTable = idTable;
            IdStaff = idStaff;
            TimeStart = timeStart;
            TimeEnd = timeEnd;
            PhoneNum = phoneNum;
        }
        public DTO_SetTable()
        {
        }

        public DTO_SetTable(string idTable, string idStaff, DateTime timeStart, string phoneNum)
        {
            IdTable = idTable;
            IdStaff = idStaff;
            TimeStart = timeStart;
            PhoneNum = phoneNum;
        }

        public DTO_SetTable(string idTable, string idStaff, DateTime timeStart)
        {
            IdTable = idTable;
            IdStaff = idStaff;
            TimeStart = timeStart;
        }
    }
}
