using day5Work4_InterfaceAbstractDemo_.Entities;

namespace day5Work4_InterfaceAbstractDemo_.Concrete
{
    internal interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}