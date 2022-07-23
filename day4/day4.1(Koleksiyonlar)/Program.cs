using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4._1_Koleksiyonlar_
{
    internal class Program
    {
        static void Main(string[] args)
        {   //Arrayler bizim oluşturduğumuz sınırlarda takılır sadece. O sınırların dışına çıkmaz.
            //Arraylerde sabitlik var.
            //string[] isimler = new string[] { "Engin", "Murat", "Kerem", "Halil" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);


            List<string> isimler2 = new List<string>() { "Engin", "Murat", "Kerem", "Halil" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);


            Console.ReadLine();
        }
    }
}
