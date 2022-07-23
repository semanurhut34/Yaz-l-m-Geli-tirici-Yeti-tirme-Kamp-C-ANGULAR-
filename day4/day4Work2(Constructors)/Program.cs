using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4Work2_Constructors_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Customer customer = new Customer { Id = 1, FirstName="Engin",Surname="Demiroğ",City="Ankara" };


            Customer customer2 = new Customer(2,"Derin","Demiroğ","Ankara");

            Customer customer3 = new Customer();
            customer3.Id = 3;

            Console.WriteLine(customer2.FirstName); 

            Method(1, "Sema", "Hut", "İstanbul");
            Console.ReadLine();
        }
        static void Method(int id,string firstName,string LastName,string city)
        {

        }
    }
    class Customer
    {
        public Customer() //Buna default constructor denir
        {
        }
        public Customer(int id, string firstName, string lastName, string city) //constructor da bir method gibi çalışır.
        {
            Id=id;
            FirstName = firstName;
            Surname = lastName;
            City = city;
            
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }

    }
}
