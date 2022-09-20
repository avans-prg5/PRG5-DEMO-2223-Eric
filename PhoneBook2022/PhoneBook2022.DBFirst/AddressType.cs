using System;
using System.Collections.Generic;

namespace PhoneBook2022.DBFirst
{
    public partial class AddressType
    {
        public AddressType()
        {
            Addresses = new HashSet<Address>();
        }

        public string Type { get; set; } = null!;
        public string? Description { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }
    }
}
