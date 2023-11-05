using System;
using System.Collections.Generic;
using System.Text;

namespace GEM.AddressBook
{
    internal class ContactList : System.Collections.ObjectModel.KeyedCollection<Guid, Contact>
    {
        protected override Guid GetKeyForItem(Contact item)
        {
            return item.Id;
        }
    }
}
