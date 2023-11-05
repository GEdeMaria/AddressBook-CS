using System;
using System.Collections.Generic;
using System.Text;

namespace GEM.AddressBook
{
    internal class ContactPhone
    {
        public string Number { get; set; }
        public PhoneTypes Type { get; set; }
        public ContactPhone()
        {
            Number = string.Empty;
            Type = 0;
        }

        public ContactPhone(string data)
        {
            string[] parts = data.Split(',');
            Number = parts[0];
            Type = (PhoneTypes)Convert.ToInt32(parts[1]);
        }

        public override string ToString()
        {
            return $"{Number},{(int)Type}";
        }
    }
}
