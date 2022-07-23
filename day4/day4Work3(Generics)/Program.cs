using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4Work3_Generics_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            Console.WriteLine(sehirler.Count);
            //sehirler.Add("Ankara");

            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("Ankara");
            Console.WriteLine(sehirler2.Count);

            Console.ReadLine();
        }

    }
    class MyList<T>   //GENERİC CLASS
    {
        T[] _array;
        T[] _tempArray; //Geçiçi 
        public MyList() //ctor yaz iki kez tab tab yap
        {
            _array = new T[0];
        }
        public void Add(T item)
        {
            _tempArray = _array;
            _array = new T[_array.Length+1];
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }
            _array[_array.Length - 1] = item;



        }
        public int Count
    {
        get { return _array.Length; }

    }

        
    }

    

    

}
