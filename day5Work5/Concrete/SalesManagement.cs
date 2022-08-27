using day5Work5.Abstract;
using day5Work5.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5Work5.Concrete
{
    internal class SalesManagement : ISellService
    {
        public void Selling(Product product, Customer customer)
        {
            Console.WriteLine("{0} oyunu {1} adlı kullanıcıya {2} TL'ye  tanımlanmıştır.",product.Name, customer.FirstName,product.Price);
        }

        public void Selling(Product product, Customer customer, Campaign campaign)
        {
            product.DiscountedPrice = product.Price - campaign.DiscountRate / 100;
            Console.WriteLine("{0} Oyunu {1} Adlı Kullanıcıya {2} Kampanyasıyla {3} indirimle {4} TL ye tanımlanmıştır.", product.Name, customer.FirstName, campaign.Name, campaign.DiscountRate, product.DiscountedPrice);
        }
    }
}
