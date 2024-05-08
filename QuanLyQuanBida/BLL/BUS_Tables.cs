using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BUS_Tables
    {
        DAL_Tables DAL_Tables = new DAL_Tables();
        public DTO_Tables GetInfoTable(string idTable)
        {
            if (string.IsNullOrEmpty(idTable))
            {
                return null;
            } else
            {
                return DAL_Tables.GetTableList_DAL(idTable);
            }
        }
    }
}
