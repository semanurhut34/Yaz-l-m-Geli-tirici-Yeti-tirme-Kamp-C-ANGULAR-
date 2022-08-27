using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5._1_OOP3_
{
    internal class DatabaseLoggerService : ILoggerService
    {
        //implemented operation(Tamamlanmış operasyon)
        public void Log()
        {
            Console.WriteLine("Veritabanına loglandı.");
        }
    }
}
