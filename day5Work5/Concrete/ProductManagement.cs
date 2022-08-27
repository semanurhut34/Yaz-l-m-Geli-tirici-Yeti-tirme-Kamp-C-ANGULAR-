using day5Work5.Abstract;
using day5Work5.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5Work5.Concrete
{
    internal class ProductManagement : IProductService
    { 
        public void Save(Product product)
        {
            Console.WriteLine("{0} saved.", product.Name);
        }
        
        public void Update(Product product)
        {
            Console.WriteLine("{0} updated.", product.Name);
        }

        public void Delete(Product product)
        {
            Console.WriteLine("{0} deleted.", product.Id);
        }
    }
}
