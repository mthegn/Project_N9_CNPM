using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Shifts
    {
        public string IDShift { get; set; }
        public int Month { get; set; }
        public int Week { get; set; }
        public string IDStaff { get; set; }
        public DateTime TimeLine { get; set; }
        public int Shift { get; set; }

        public DTO_Shifts(string idShift, string idStaff, DateTime timeLine, int month, int week, string iDStaff, int shift)
        {
            IDShift = idShift;
            IDStaff = idStaff;
            TimeLine = timeLine;
            Month = month;
            Week = week;
            IDStaff = iDStaff;
            Shift = shift;
        }

        public DTO_Shifts(string idShift, DateTime timeLine, int shift, int week, int month)
        {
            IDShift = idShift;
            TimeLine = timeLine;
            Month = month;
            Week = week;
            Shift = shift;
        }

        public DTO_Shifts()
        {
        }
    }
}
