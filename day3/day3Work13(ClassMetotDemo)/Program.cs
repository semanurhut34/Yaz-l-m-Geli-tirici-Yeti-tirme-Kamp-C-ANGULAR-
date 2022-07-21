using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3Work1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Name = "Sema";
            musteri1.Surname = "Hut";
            musteri1.Email = "qwert";
            musteri1.PhoneNumber = 055554433;
            musteri1.Password = "merhaba";

            MusteriManager musteriManager1 = new MusteriManager();
            musteriManager1.Add(musteri1);
            musteriManager1.Listing(musteri1);
            musteriManager1.Update(musteri1);
            musteriManager1.Delete(musteri1);
            musteriManager1.Add(musteri1);


            Console.ReadLine();
        }
    }
}
