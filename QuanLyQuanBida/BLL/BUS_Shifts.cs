using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BUS_Shifts
    {
        DAL_Staff DAL_Staff = new DAL_Staff();
        DAL_Shifts DAL_Shifts = new DAL_Shifts();
        public bool UpdateShift_BUS(string shift, int month, int week, string idStaff, DateTime time)
        {
            string idShift = "ca" + shift + week.ToString() + month.ToString();
            if (DAL_Staff.CheckStaff_DAL(idStaff))
            {
                if (DAL_Shifts.CheckShift_DAL(idShift))
                {
                    DAL_Shifts.UpdateShift_DAL(shift, month, week, idStaff, time);
                    return true;
                } else
                {
                    DAL_Shifts.CreateShift_DAL(month, week, idStaff, time, shift);
                    return true;
                }
            }
            return false;
        }

        public string GetStaffShift_BUS(string shift, int month, int week)
        {
            return DAL_Shifts.GetStaffShift_DAL(shift, month, week);
        }

        public List<DTO_Shifts> GetShiftOfStaff_BUS(string user, int month, int week)
        {
            if (user == null)
            {
                return null;
            }
            return DAL_Shifts.GetShiftOfStaffList_DAL(user, month, week);
        }

        public int CalculateSalary_BUS(int month, string idStaff, int salaryPerShift)
        {
            return DAL_Shifts.CalculateSalary_DAL(month, idStaff, salaryPerShift);
        }
    }
}
