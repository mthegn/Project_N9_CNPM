using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Tables
    {
        public string IdTable { get; set; }
        public string Classify { get; set; }
        public float Price { get; set; }
        public string Situation { get; set; }


        public DTO_Tables(string idTable, string classify, float price, string situation)
        {
            IdTable = idTable;
            Classify = classify;
            Price = price;
            Situation = situation;
        }

        public DTO_Tables(string idTable, string classify, string situation)
        {
            IdTable = idTable;
            Classify = classify;
            Situation = situation;
        }
        public DTO_Tables()
        {
        }
    }
}
