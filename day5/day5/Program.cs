using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demiroğ";
            musteri1.TcNo = "123456787654";


            TuzelMusteri musteri2= new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "1234";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "6789";

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            musteriManager.Ekle(musteri4);


            //İnheritance yapma sebebi, base class gercekMusteri ve TuzelMusterinin referansını tutabiliyor ve Manager clası içinde de kullanıyor.
            //Poliforminizm-->çok biçimlilik
            //Base sınıf, referans tutucudur.


            //Gerçek Müşteri - Tüzel Müşteri
            //SOLID -->S harfi, Tek Sorumluluk İlkesi,Bir sınıf (nesne) yalnızca bir amaç uğruna değiştirilebilir, o da o sınıfa yüklenen sorumluluktur, yani bir sınıfın(fonksiyona da indirgenebilir) yapması gereken yalnızca bir işi olması gerekir.;
            //O harfi,Açık Kapalı İlke, Bir sınıf ya da fonksiyon halihazırda var olan özellikleri korumalı ve değişikliğe izin vermemelidir. Yani davranışını değiştirmiyor olmalı ve yeni özellikler kazanabiliyor olmalıdır.;
            //L harfi,Kodlarımızda herhangi bir değişiklik yapmaya gerek duymadan alt sınıfları, türedikleri(üst) sınıfların yerine kullanabilmeliyiz. ;
            //I harfi,Arayüz Ayrıştırma İlkesi, Sorumlulukların hepsini tek bir arayüze toplamak yerine daha özelleştirilmiş birden fazla arayüz oluşturmalıyız.;
            //D harfi,Bağımlılık Tersine Çevirme İlkesi, Sınıflar arası bağımlılıklar olabildiğince az olmalıdır özellikle üst seviye sınıflar alt seviye sınıflara bağımlı olmamalıdır.
            //Kaynakça =https://gokhana.medium.com/solid-nedir-solid-yaz%C4%B1l%C4%B1m-prensipleri-nelerdir-40fb9450408e
        }
    }
}
