using day5Work4_InterfaceAbstractDemo_.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5Work4_InterfaceAbstractDemo_.Abstract
{
    internal abstract class BaseCustomerManager : ICustomerCheckService
    {
        public void CheckIfRealPerson(Customer customer)
        {
            throw new NotImplementedException();
        }

        public virtual void Save(Customer customer) //virtual-->ben bunu ezebilirim.
        {
            Console.WriteLine("Saved to db : "+customer.FirstName);
        }

        bool ICustomerCheckService.CheckIfRealPerson(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
