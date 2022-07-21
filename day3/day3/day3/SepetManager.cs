using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3
{
    internal class SepetManager
    {
        //naming convention --> İsimlendirme kuralı
        //Syntax -->Yazım değişiklikleri
        //Birden fazla method olabilir.
        public void Ekle(Product urun) //Method, buna imza deniyor.
        {
            Console.WriteLine("Tebrikler! Sepete Eklendi:  "+ urun.Adi);
        }

        public void Ekle2(string urunAdi, string aciklama,double fiyat,int stokAdedi)
        {
            Console.WriteLine("Tebrikler! Sepete Eklendi:  " + urunAdi);
        }
    }
}
