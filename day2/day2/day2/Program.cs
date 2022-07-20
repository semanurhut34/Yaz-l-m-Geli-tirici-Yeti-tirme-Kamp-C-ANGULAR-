using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Type safety --> tip güvenliği
            //Do not repeat yourself --> Kendini tekrarlama

            string kategoriEtiketi = "Kategori"; //Bu bir değer tutucu,alias
            int ogrenciSayisi = 32000; //Tam sayı
            double faizOranı = 1.45; //Ondalıklı sayı
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.55;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış okur");
            }
            else if(dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış oku");
            }
            else
            {
                Console.WriteLine("Değişmedi oku");
            }

            if(sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }
            //Fonksiyonlar kodu tekrar tekrar kullanmamızı sağlar.

            Console.WriteLine(kategoriEtiketi);


            Console.ReadLine();
        }
    }
}
