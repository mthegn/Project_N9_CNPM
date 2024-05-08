using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Staff
    {
        public string IdStaff { get; set; }
        public string Account { get; set; }
        public string NameStaff { get; set; }
        public string PhoneNum { get; set; }
        public string Position { get; set; }


        public DTO_Staff(string idStaff, string idUser, string nameStaff, string phoneNum, string position)
        {
            IdStaff = idStaff;
            Account = idUser;
            NameStaff = nameStaff;
            PhoneNum = phoneNum;
            Position = position;
        }
        public DTO_Staff()
        {
        }

        public DTO_Staff(string nameStaff, string phone, string account)
        {
            NameStaff = nameStaff;
            PhoneNum = phone;
            Account = account;
        }

        public DTO_Staff(string nameStaff, string phone, string account, string idStaff)
        {
            NameStaff = nameStaff;
            PhoneNum = phone;
            Account = account;
            IdStaff = idStaff;
        }

    }
}
