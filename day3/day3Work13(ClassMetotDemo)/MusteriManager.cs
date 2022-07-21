using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3Work1
{
    internal class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine("Müşteri eklendi: "+ musteri.Name);
        }
        public void Listing(Musteri musteri)
        {
            
            Console.WriteLine((musteri.Name + " " + musteri.Surname + " : " + musteri.PhoneNumber + " Listelendi."));
        }
        public void Update(Musteri musteri)
        {
            Console.WriteLine("Müşteri bilgisi güncellendi: "+musteri.Id);
        }
        public void Delete(Musteri musteri)
        {
            Console.WriteLine("Müşteri silindi: "+musteri.Surname);
        }
    }
}
