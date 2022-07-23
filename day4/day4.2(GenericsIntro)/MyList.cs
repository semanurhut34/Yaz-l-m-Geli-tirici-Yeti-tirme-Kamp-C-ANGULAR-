using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4._2_GenericsIntro_
{
    internal class MyList<T> //Type(Tip) demek.Bu T sayesinde
                             //metoda sadece string göndermeme gerek yok, kullanıcı ne gönderirse onu kabul eder.
    {
        T[] items;
        public MyList()  //ctor yapıp tab-tab yap. //constructor-->Aslında bir method. Class'ı newleyince bu otomatik çalışıyor.
        {
            items = new T[0];

        }

        public void Add(T item)
        {
            //Önceki değerlerimi korumak için bunu yazıyorum.
            T[] tempArray = items; //geçiçi dizi (referansı buna tutturuyoruz)(elemanların kaybolmamasını sağlıyor bu sayede yeni eleman ekleyebiliyoruz.)
            items=new T[items.Length+1]; //Eleman sayısını bir arttırdım.
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];      //Temparraydeki değerleri items'a geri alıyorum.
            }
            items[items.Length-1] = item;
            

        }
    }
}
