using day5Work5.Abstract;
using day5Work5.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5Work5.Concrete
{
    internal class CustomerManagement : ICustomerService
    {
        private ICustomerCheckService _customerCheckService;
        public CustomerManagement(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public CustomerManagement()
        {
        }

        public void Save(Customer customer)
            
        {
            if(_customerCheckService.CheckIfRealPerson(customer))
            
                Console.WriteLine("{0} saved.", customer.FirstName);
            
            else
            
                throw new Expection("Customer is not real.");
            
        }
        public void Update(Customer customer)
        {
            Console.WriteLine("{0} updated.", customer.LastName);
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine("{0} deleted.", customer.Id);
        }
    } 
}
