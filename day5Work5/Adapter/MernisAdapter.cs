using day5Work5.Abstract;
using day5Work5.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5Work5.Adapter
{
    internal class MernisAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            MernisServiceReference1.KPSPublicSoapClient client = new MernisServiceReference1.KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(Convert.ToInt32(customer.NationalityId),customer.FirstName.ToUpper(),customer.LastName.ToUpper(),customer.DateOfBirth.Year);
        }
    }
}
