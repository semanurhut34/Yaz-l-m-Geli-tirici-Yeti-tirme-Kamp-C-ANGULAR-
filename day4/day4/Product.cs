using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4
{
    internal class Product //Entity --> Varlık
    {

        //snippet --> tab tab yapınca gelen hazır kod
        public int Id { get; set; }

        public int CategoryId { get; set; }

        public string ProductName { get; set; }

        public double UnitPrice { get; set; }

        public int UnitsInStock { get; set; }  //Stok adedi

    }
}
