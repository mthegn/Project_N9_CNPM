using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BUS_SetTable
    {
        DAL_VIP DAL_VIP = new DAL_VIP();
        DAL_SetTable DAL_SetTable = new DAL_SetTable();
        public bool SetTable_BUS(DTO_SetTable setTable)
        {
            if (setTable.PhoneNum != "" && (!DAL_VIP.CheckPhoneVIP_DAL(setTable.PhoneNum)))
            {
                return false;
            }
            if (!DAL_Staff.CheckStaff_DAL(setTable.IdStaff))
            {
                return false;
            }
            DAL_SetTable.SetTable_DAL(setTable);
            return true;
        }

        public void Reset_BUS(string idTable)
        {
            DAL_SetTable.Reset_DAL(idTable);
        }
    }
}
