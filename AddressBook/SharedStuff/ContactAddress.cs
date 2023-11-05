using System;
using System.Collections.Generic;
using System.Text;

namespace GEM.AddressBook
{
    internal class ContactAddress
    {
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Zip { get; set; }

        public ContactAddress()
        {
            Line1 = string.Empty;
            Line2 = string.Empty;
            City = string.Empty;
            State = string.Empty;
            Country = string.Empty;
            Zip = string.Empty;
        }

        public ContactAddress(string data)
        {
            string[] parts = data.Split(',');
            Line1 = parts[0];
            Line2 = parts[1];
            City = parts[2];
            State = parts[3];
            Country = parts[4];
            Zip = parts[5];
        }

        public override string ToString()
        {
            return $"{Line1},{Line2},{City},{State},{Country},{Zip}";
        }
    }
}
