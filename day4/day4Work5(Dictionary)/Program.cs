using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4Work5_Dictionary_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> myDictionary = new MyDictionary<string>();
            myDictionary.Add("İstanbul", "34");
            myDictionary.Add("Adana", "01");
            myDictionary.Add("Antalya", "07");
            myDictionary.Add("Kocaeli", "42");

            Console.WriteLine(myDictionary.Count);
            Console.ReadLine();
        }
        }
    }

class MyDictionary<T>
{
    T[] items;
    public MyDictionary()
    {
        items = new T[0];
    }


    public void Add(T item,T value)
    {
        T[] tempArray = items;
        items = new T[items.Length + 1];

        for (int i = 0; i < tempArray.Length; i++)
        {
            items[i] = tempArray[i];
        }
        items[items.Length-1]= item;
    }

    public int Count
    {
        get{ return items.Length; }
}
}