using System;

namespace day5Work4_InterfaceAbstractDemo_.Entities
{
    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }
        public long NationalityId { get; set; }
    }
}
