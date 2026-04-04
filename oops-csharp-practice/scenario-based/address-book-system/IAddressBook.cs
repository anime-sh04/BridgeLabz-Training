using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal interface IAddressBook
    {
        void AddContact();
        void DisplayContacts();
        void EditContactUsingName();
        void DeleteContactUsingName();
        void AddMultipleContacts();
        void SortContactsByName();
    }
}
