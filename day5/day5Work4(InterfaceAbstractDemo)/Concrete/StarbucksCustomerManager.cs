using day5Work4_InterfaceAbstractDemo_.Abstract;
using day5Work4_InterfaceAbstractDemo_.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5Work4_InterfaceAbstractDemo_.Concrete
{
    internal class StarbucksCustomerManager : BaseCustomerManager
    {

        ICustomerCheckService _customerCheckService;
        private MernisServiceAdapter mernisServiceAdapter;

        public StarbucksCustomerManager(MernisServiceAdapter mernisServiceAdapter)
        {
            this.mernisServiceAdapter = mernisServiceAdapter;
        }

        public override void Save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
             throw new Exception("Not a valid person");
            }
            
            CheckIfRealPerson(customer);
            base.Save(customer);
        }

        
    }
}
