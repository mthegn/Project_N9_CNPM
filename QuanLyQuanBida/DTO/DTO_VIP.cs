using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_VIP
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public int Points { get; set; }

        public DTO_VIP(string name, string phone)
        {
            Name = name;
            Phone = phone;
        }

        public DTO_VIP(int points)
        {
            Points = points;
        }

        public DTO_VIP()
        {
        }
    }
}
