using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4Work1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int,decimal,float,enum,boolean --> value types //Sadece değer tip atanır.
            int sayi1 = 10;
            int sayi2 = 20;
            sayi1 = sayi2;
            sayi2 = 100;
            Console.WriteLine("Sayı 1: " + sayi1); //20

            Console.WriteLine("***************");

            //arrays,class,interface.. reference types (referans tip)
            int[] sayilar1 = new int[] { 1, 2, 3 };
            int[] sayilar2 = new int[] { 10, 20, 30 };
            sayilar1 = sayilar2;
            sayilar2[0] = 1000;
            Console.WriteLine("Sayılar1[0] = " + sayilar1[0]); //1000

            Console.WriteLine("**************");

            Person person = new Person();
            Customer customer = new Customer();
            Employee employee = new Employee();
            employee.FirstName = "Ahmet";

            Person person1 = new Person();
            person1.FirstName = "Engin";

            Person person2 = new Person();
            

            person1.FirstName = person2.FirstName;
            person2.FirstName = "Derin";
            Console.WriteLine(person1.FirstName);

            customer.FirstName = "Sema";
            customer.CreditCardNumber = "1234567";
            Person person3 = customer;
            Console.WriteLine(person3.FirstName);

            Console.WriteLine(((Customer)person3).CreditCardNumber);

            PersonManager personManager = new PersonManager();
            personManager.Add(employee);




            Console.ReadLine();
        }
    }
    class Person //base class
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Customer : Person
    {
        public string CreditCardNumber { get; set; }
    }
    class Employee : Person
    {

        public int EmployeeNumber { get; set; }
    }

    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}

