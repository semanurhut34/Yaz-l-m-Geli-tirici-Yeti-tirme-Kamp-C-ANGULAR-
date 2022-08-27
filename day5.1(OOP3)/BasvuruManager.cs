using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5._1_OOP3_
{
    internal class BasvuruManager
    {
        //Method injection yapıyoruz burada(parantezlerin içindekine deniyor)
        public void BasvuruYap(IKrediManager krediManager,List<ILoggerService> loggerServices)
        {
            krediManager.Hesapla();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
