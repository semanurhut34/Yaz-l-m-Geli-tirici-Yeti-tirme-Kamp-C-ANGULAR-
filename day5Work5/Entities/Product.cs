using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5Work5.Entities
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Detail { get; set; }
        public double Price { get; set; }
        public double DiscountedPrice { get; set; }
    }
}
