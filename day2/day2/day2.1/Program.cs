using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Döngüleri birbirine benzeyen işlemleri tekrar etmek için kullanırız.
            //Array --> dizi

            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı"; //Sadece 1 tane string tutar.
            string kurs2 = "Programlamaya Başlamak İçin Temel Kurs";
            string kurs3 = "Java";

            string[] kurslar = new string[] {"Yazılım Geliştirici Yetiştirme Kampı","Programlamaya Başlamak İçin Temel Kurs", "Java", "Python"}; //Birden fazla string tutarız. Dinamik sistem.
            //Döngüleri elimizdeki veriyi dönmek için kullanıyoruz.

            for (int i = 0; i < kurslar.Length; i++)  //Length -->Eleman sayısı
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("for bitti.");

            foreach (string kurs in kurslar)  //Dizi temelli yapıları tek tek dönmeye yarıyor.
            {
                Console.WriteLine(kurs);
            }

            Console.ReadLine();
        }
    }
}
