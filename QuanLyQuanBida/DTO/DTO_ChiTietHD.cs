using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ChiTietHD
    {
        public DTO_ChiTietHD() { }

        public int ID { get; set; }
        public string IdTable { get; set; }
        public DateTime BeginAt { get; set; }
        public DateTime FinishAt { get; set; }
        public double Price { get; set; }
        public string PhoneNum { get; set; }
        public string NameCus { get; set; }

        public DTO_ChiTietHD(int id, string idTable, DateTime beginAt, DateTime finishAt, double price, string phoneNum, string nameCus)
        {
            ID = id;
            IdTable = idTable;
            BeginAt = beginAt;
            FinishAt = finishAt;
            Price = price;
            PhoneNum = phoneNum;
            NameCus = nameCus;
        }
    }
}
