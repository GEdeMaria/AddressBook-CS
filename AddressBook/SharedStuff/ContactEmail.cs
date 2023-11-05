using System;
using System.Collections.Generic;
using System.Text;

namespace GEM.AddressBook
{
    internal class ContactEmail
    {
        public string Address { get; set; }
        public EmailTypes Type { get; set; }

        public ContactEmail()
        {
            Address = string.Empty;
            Type = 0;
        }

        public ContactEmail(string data)
        {
            string[] parts = data.Split(',');
            Address = parts[0];
            Type = (EmailTypes)Convert.ToInt32(parts[1]);
        }

        public override string ToString()
        {
            return $"{Address},{(int)Type}";
        }
    }
}
