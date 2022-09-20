using System;
using System.Collections.Generic;

namespace PhoneBook2022.DBFirst
{
    public partial class Address
    {
        public int PersonId { get; set; }
        public string AdresType { get; set; } = null!;
        public string Street { get; set; } = null!;
        public string Number { get; set; } = null!;
        public string PostalCode { get; set; } = null!;
        public string? Extension { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Country { get; set; }

        public virtual AddressType AdresTypeNavigation { get; set; } = null!;
        public virtual Person Person { get; set; } = null!;
    }
}
