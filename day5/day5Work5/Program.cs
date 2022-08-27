using day5Work5.Concrete;
using day5Work5.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5Work5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManagement customerManagement = new CustomerManagement();

            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "Semanur";
            customer1.LastName = "Hut";
            customer1.DateOfBirth= new DateTime(2001,03,01) ;
            //customerManagement.Save(customer1);
            customerManagement.Update(customer1);

            ProductManagement productManagement=new ProductManagement();
            Product product1 = new Product();
            product1.Id = 1;
            product1.Name = "Lol";
            product1.Detail = "Aksiyon";
            product1.DiscountedPrice = 10;
            product1.Price = 50;
            
            productManagement.Save(product1);
            productManagement.Update(product1);

            CampaignManagement campaignManagement = new CampaignManagement();

            Campaign campaign = new Campaign();
            campaign.Id = 1;
            campaign.Name = "Büyük İndirim";
            campaign.Detail = "Çok İndirim";
            campaign.DiscountRate = 10;

            campaignManagement.Add(campaign);
            campaignManagement.Update(campaign);

            SalesManagement salesManagement = new SalesManagement();
            salesManagement.Selling(product1, customer1);
            salesManagement.Selling(product1, customer1,campaign);
            

            Console.ReadLine();
        }
    }
}
