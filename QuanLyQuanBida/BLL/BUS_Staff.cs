using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BUS_Staff
    {
        DAL_Staff DAL_Staff = new DAL_Staff();
        public DTO_Staff GetStaffInfo_BUS(DTO_Staff staff)
        {
            if (staff.Account != null)
            {           
                return DAL_Staff.GetStaffInfo_DAL(staff);
            }
            return null;
        }

        public List<DTO_Staff> GetStaffList()
        {

            return DAL_Staff.GetStaffInfoList_DAL();
        }

        public bool AddStaff_Bus(DTO_Staff staff)
        {
            if (DAL_Staff.CheckAccount_DAL(staff.Account))
            {
                return false;
            }
            if (staff.NameStaff != null && staff.PhoneNum != null && staff.Account != null) 
            {
                DAL_Staff.AddStaff_DAL(staff);
                DAL_Staff.CreateAccount_DAL(staff);
                return true;
            }
            return false;
        }

        public DTO_Staff GetStaffById_BUS(DTO_Staff staff)
        {
            if (DAL_Staff.CheckStaff_DAL(staff.IdStaff))
            {
                return DAL_Staff.GetStaffInfoById_DAL(staff);
            }
            return null;
        }

        public bool ChangeStaff_BUS(DTO_Staff newStaff)
        {
            DTO_Staff preStaff = GetStaffById_BUS(newStaff);
            if (newStaff.IdStaff == "" || !DAL_Staff.CheckStaff_DAL(newStaff.IdStaff) || preStaff == null) 
            {
                return false;
            }
            if (newStaff.NameStaff == "")
            {
                newStaff.NameStaff = preStaff.NameStaff;
            }
            if (newStaff.PhoneNum == "")
            {
                newStaff.PhoneNum = preStaff.PhoneNum;
            }
            if (newStaff.Account == "")
            {
                newStaff.Account = preStaff.Account;
            }

            DAL_Staff.ChangeStaff_DAL(newStaff);
            return true;
        }

        public bool DeleteStaff_BUS (DTO_Staff staff)
        {
            if (DAL_Staff.CheckStaff_DAL(staff.IdStaff))
            {
                DAL_Staff.DeleteStaff_DAL(staff);
                return true;
            }
            return false;
        }

        public List<string> GetListID_BUS()
        {
            return DAL_Staff.GetListID_DAL();
        }
    }
}
