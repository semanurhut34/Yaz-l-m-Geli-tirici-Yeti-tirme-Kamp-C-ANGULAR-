using day5Work4_InterfaceAbstractDemo_.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5Work4_InterfaceAbstractDemo_.Abstract
{
    internal interface ICustomerCheckService : IEntitiy
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
