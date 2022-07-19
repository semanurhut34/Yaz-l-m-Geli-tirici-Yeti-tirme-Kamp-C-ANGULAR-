using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Neden değişkenlere atama yapıyoruz?
            //Çünkü bir yerde hata varsa ya da değişiklik yapılacaksa daha kolay bir şekilde yapmamızı sağlıyor.
            //Do not repeat yourself
            string baslik = "İlginizi Çekebilir !";  //string
            int vade = 48;    //integer
            float faizOranı = 1.69f;  //float
            Console.WriteLine(baslik);
            Console.WriteLine(vade);
            Console.WriteLine(baslik.GetType()); //Değişkenin tipini öğrenmeye yarar.
            //Değişken tanımlamada değişkenlerin ismi bitişik yazılacak ya da arada _(alt tire) olacak, boşluk kullanılmaz.
            //operatör== + --> İki metni birleştirir, iki sayıyı toplar.
            //syntax = Her programlama dilinin yazımı diğerlerinden farklıdır.
            //indentation = Belli boşluk bırakma(mesela döngülerde)
            //Döngüler

            float dolarDun = 7.35f;
            float dolarBugün = 7.45f;

            if (dolarDun > dolarBugün)
            {
                Console.WriteLine("Azalış oku");
            }
            else
            {
                Console.WriteLine("Artış oku"); //İki değer eşit olsaydı else çalışırdı.
            }


            List<string> krediler = new List<string>();
            krediler.Add("Hızlı Kredi");
            krediler.Add("Maaşını Halkbanktan...");
            krediler.Add("Mutlu Emekli");

            for(int i=0; i <= krediler.Count; i++)
            {
                Console.WriteLine(krediler[i]);
            }

            //Fonksiyonlar
             void krediListele()
            {
                List<string> kredilerr = new List<string>();
                krediler.Add("Hızlı Kredi");
                krediler.Add("Maaşını Halkbanktan...");
                krediler.Add("Mutlu Emekli");

                for (int i = 0; i <= kredilerr.Count; i++)
                {
                    Console.WriteLine(kredilerr[i]);
                }
            }
            krediListele();



            Console.ReadLine();
        }
    }
}
