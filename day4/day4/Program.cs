using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CRUD--> create,read(listeleme),update,delete
            //Pascal Case, kelimelerin ilk harfi büyük yazılır(classlarda kullanılır)
            //Camel Case,kelimelerin ilk harfi küçük, diğer kelimenin ikinci harfi büyük yazılır(değişken isimlendirmede kullanılır)
            //case sensitive,küçük büyük harf duyarlılığı

            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product { Id = 2, CategoryId = 5, UnitsInStock = 5,ProductName="kalem",UnitPrice=35 };

            ProductManager productManager = new ProductManager(); //Referans tipleri newlemen lazım.Sol taraf stack, sağ taraf heap.
            productManager.Add(product1);

            //productManager.Topla2(3, 6);

            //int toplamSonucu = productManager.Topla(3, 6);
            //Console.WriteLine(toplamSonucu*2);

        }
    }
}
