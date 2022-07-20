using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2Work6
{
    internal class Program
    {

        class Product
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int price { get; set; }
            public bool guarantee { get; set; }

        }
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.Name = "Huawei";
            product1.price = 5000;
            product1.guarantee = true;

            Product product2 = new Product();
            product2.Id = 2;
            product2.Name = "Samsung";
            product2.price = 10000;
            product2.guarantee = false;

            Product product3 = new Product();
            product3.Id = 3;
            product3.Name = "Monster";
            product3.price = 15000;
            product3.guarantee = true;

            Product [] products= { product1, product2, product3 };

            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].Name);
            }
            Console.WriteLine("*************");

            foreach (var product in products)
            {
                Console.WriteLine(product.price);
            }
            Console.WriteLine("**************");

            int a = 0;
            while (a < products.Length)
            {
                Console.WriteLine(products[a].guarantee);
                a++;
            }
            Console.ReadLine();
        }
    }
}
