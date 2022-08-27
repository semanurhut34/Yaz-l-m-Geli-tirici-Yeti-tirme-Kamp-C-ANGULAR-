using day5Work4_InterfaceAbstractDemo_.Abstract;
using day5Work4_InterfaceAbstractDemo_.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5Work4_InterfaceAbstractDemo_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Entities.Customer { DateOfBirth = new System.DateTime(1985, 1, 6), FirstName = "Engin", LastName = "Demiroğ", NationalityId = 3423421344, });

            Console.ReadLine();

        }

    }
}
