using day5Work4_InterfaceAbstractDemo_.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5Work4_InterfaceAbstractDemo_.Concrete
{
    internal class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }

        public void Save(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
