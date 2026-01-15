using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace AddressBook
{
    internal class AddresssBook // - UC6 Added Multiple Address Books
    {
        public string BookName { get; private set; }
        public ContactPerson[] Contacts = new ContactPerson[1000];
        public int Count = 0;

        public AddresssBook(string bookName)
        {
            BookName = bookName;
        }
    }
}
