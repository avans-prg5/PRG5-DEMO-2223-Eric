using System;
using System.Collections.Generic;

namespace PhoneBook2022.DBFirst
{
    public partial class Person
    {
        public Person()
        {
            Addresses = new HashSet<Address>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string TelephoneNumber { get; set; } = null!;

        public virtual ICollection<Address> Addresses { get; set; }
    }
}
