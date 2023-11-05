using System;
using System.Collections.Generic;
using System.Text;

namespace GEM.AddressBook
{
    internal class AddressBook
    {
        public ContactList Contacts;

        public Contact this[int index]
        {
            get => Contacts[index];
        }

        public AddressBook() 
        {
            Contacts = new ContactList();
        }

        public void CreateContact()
        {
            bool _freshId = false;
            Guid _newId = new Guid();
            while (!_freshId)
            {
                _newId = Guid.NewGuid();
                if (!Contacts.Contains(_newId)) { _freshId = true; }
            }
            Contacts.Add(new Contact(_newId));
        }
        public void DeleteContact(Contact contact)
        {
            Contacts.Remove(contact);
        }


        public void SaveContacts(string path)
        {
            List<string> lines = new List<string>();
            foreach (Contact contact in Contacts)
                lines.Add(contact.ToString());
            File.WriteAllLines(path, lines);
        }
        public void LoadContacts(string path)
        {
            string[] lines = File.ReadAllLines(path);
            foreach (string line in lines)
            {
                Contacts.Add(new Contact(line));
            }
        }
    }
}
