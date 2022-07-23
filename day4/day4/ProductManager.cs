using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4
{
    internal class ProductManager
    {

        //void -->emir kipindeki işlemi yapıyor
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi");
        }

        //public int Topla(int sayi1,int sayi2)  //işlem sonucunu tekrar kullanmamıza yarar.
        //{
        //    return sayi1 + sayi2;
        //}
        //public void Topla2(int sayi1, int sayi2)
        //{
        //    Console.WriteLine(sayi1 + sayi2); 
        //}
    }
}
