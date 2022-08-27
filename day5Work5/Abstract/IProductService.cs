using day5Work5.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5Work5.Abstract
{
    internal interface IProductService
    {
        void Save(Product product);
        void Update(Product product);
        void Delete(Product product);
    }
}
