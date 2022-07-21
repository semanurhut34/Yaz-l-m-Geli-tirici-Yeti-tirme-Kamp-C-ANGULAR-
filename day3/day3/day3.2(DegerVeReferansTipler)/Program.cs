using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3._2_DegerVeReferansTipler_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int,decimal,float,double,bool(Sayısal görüntüde olanlar) -->değer tip
            //Array,class,interface --> referans tip
            //Bellekte stack ve heap diye iki alan var. Sen bir değişken tanımladığında stack'te gerçekleşiyor.

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2; //Burada değeri aktarırsın sonra da sayi2 ile bağlantıyı koparırsın.
            sayi2 = 65;
            Console.WriteLine(sayi1); //Çünkü bu referans tiptir


            int[] sayilar1 = new int[] { 10, 20, 30 }; //Garbage collector gelip bunu bellekten atar.
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2; //7Sayilar1'in referans numarası sayilar2'nin referans numarasına eşittir.
            sayilar2[0] = 999;
            Console.WriteLine(sayilar1[0]);
            Console.ReadLine();
        }
    }
}
