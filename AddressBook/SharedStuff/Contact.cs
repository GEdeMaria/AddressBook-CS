using System;
using System.Collections.Generic;
using System.Text;

namespace GEM.AddressBook
{
    internal class Contact
    {
        public Guid Id { get; init; }
        public ContactName Name { get; set; }
        public ContactAddress Address { get; set; }
        public ContactPhone Phones { get; set; }
        public ContactEmail Emails { get; set; }

        public Contact(Guid id)
        {
            Id = id;
            Name = new ContactName();
            Address = new ContactAddress();
            Phones = new ContactPhone();
            Emails = new ContactEmail();
        }

        public Contact(string data)
        {
            string[] parts = data.Split(';');
            Id = Guid.Parse(parts[0]);
            Name = new ContactName(parts[1]);
            Address = new ContactAddress(parts[2]);
            Phones = new ContactPhone(parts[3]);
            Emails = new ContactEmail(parts[4]);
        }

        public override string ToString()
        {
            return $"{Id};{Name};{Address};{Phones};{Emails}";
        }
    }
}
