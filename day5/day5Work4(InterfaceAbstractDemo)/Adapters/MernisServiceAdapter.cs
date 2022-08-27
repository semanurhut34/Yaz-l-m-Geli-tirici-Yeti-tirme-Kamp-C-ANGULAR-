using day5Work4_InterfaceAbstractDemo_.Abstract;
using day5Work4_InterfaceAbstractDemo_.Concrete;
using day5Work4_InterfaceAbstractDemo_.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICustomerCheckService = day5Work4_InterfaceAbstractDemo_.Concrete.ICustomerCheckService;

namespace day5Work4_InterfaceAbstractDemo_
{
    internal class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            MernisServiceReference1.KPSPublicSoapClient client = new MernisServiceReference1.KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(customer.NationalityId, customer.FirstName.ToUpper(), customer.LastName.ToUpper(), customer.DateOfBirth.Year);
        }

        public void Save(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
