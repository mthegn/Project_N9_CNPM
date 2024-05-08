using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Users
    {
        public string User { get; set; }
        public string Pass { get; set; }
        public int IdAccess { get; set; }

        public DTO_Users(string user, string pass, int idAccess)
        {
            User = user;
            Pass = pass;
            IdAccess = idAccess;
        }

        public DTO_Users()
        {
        }
    }
}
