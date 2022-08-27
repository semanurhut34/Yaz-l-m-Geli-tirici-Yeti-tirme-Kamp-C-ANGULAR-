using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5._1_OOP3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Classlar inherits, interfacelerde  implements
            //İnterfaceler ,o interface'i implements eden clasın referans numarasını tutabiliyor.
            //İnterfaceleri birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız.
            IKrediManager ıhtiyackrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FilebaseLoggerService();


            
            BasvuruManager basvuruManager = new BasvuruManager();
            //basvuruManager.BasvuruYap(ıhtiyackrediManager,databaseLoggerService);
            basvuruManager.BasvuruYap(new EsnafKredisiManager(), new List<ILoggerService> { new SmsLoggerService(),new DatabaseLoggerService()});




            List<IKrediManager> krediler= new List<IKrediManager>() { ıhtiyackrediManager, tasitKrediManager };

            basvuruManager.KrediOnBilgilendirmesiYap(krediler);

            //2.14.00

            Console.ReadLine();
        }
    }
}
