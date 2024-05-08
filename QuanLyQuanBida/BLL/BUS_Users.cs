using DAL;
using DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BUS_Users
    {
        DAL_Users DAL_Users = new DAL_Users();
        // Change pass
        public bool ChangePass_BUS(DTO_Users user, string oldPass, string confirmPass, string passCorrect)
        {
            if (oldPass.Equals(null) || confirmPass.Equals(null) || user.Pass.Equals(null))
            {
                return false;
            }

            if (oldPass == user.Pass || user.Pass != confirmPass || passCorrect != oldPass)
            {
                return false;
            }

            DAL_Users.ChangePass_DAL(user.User, user.Pass);
            return true;
        }
        // Get User
        public DTO_Users GetUserInfo_BUS(DTO_Users user)
        {
            DTO_Users dt = new DTO_Users();
            dt = DAL_Users.GetUserInfo_DAL(user);
            return dt;
        }
        // Check login
        public bool CheckLogin_BUS(string user, string pass)
        {
            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                return false;
            }

            return DAL_Users.CheckLogin_DAL(user, pass);
        }
    }
}
