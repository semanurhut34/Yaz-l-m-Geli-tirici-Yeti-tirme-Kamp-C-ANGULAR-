using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Metotlar bizim için tekrar tekrar kullanılabilirliği sağlayan kod bloklarıdır.
            //Do Not Repeat Yourself -->DRY(kısaltması)
            //Eğer ortak kod varsa onları birer metot haline getir ve o metodu tekrar tekrar kullanabilirsin.
            //Clean Code --> Temiz kod.
            //Best Practice -->Doğru Uygulama Teknikleri
            //Class da aslında veri tipidir.
            //Class'lar özellik tutuyorlar.
            //Property--> Özellik
            //Manager --> Operasyon tutuyor.



            Product urun1=new Product(); //Class olduğu zaman newlemen gerekiyor.
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Product urun2=new Product();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Product[] urunler = new Product[] { urun1, urun2 }; //Array

            foreach (Product urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("--------------");
            }

            //type safe --> tip güvenli


            Console.WriteLine("********METHODLAR********");

            //instance--> class örneği oluşturma

            //encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut","Yeşil Armut",12,3);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 12, 3);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12, 3);



            Console.ReadLine();




        }
    }
}
