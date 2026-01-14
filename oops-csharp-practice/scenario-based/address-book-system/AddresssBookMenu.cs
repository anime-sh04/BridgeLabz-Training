using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class AddresssBookMenu
    {
        private AddresssBook book = new AddresssBook();
        public void Menu()
        {
            while (true)
            {
                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. Display Contacts");

                Console.WriteLine("3. Edit Contact");
                Console.WriteLine("0. Exit");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 0:return;
                    case 1:
                        book.AddContact();
                        Console.WriteLine("Added Contact Successfully");
                        break;
                    case 2:
                        book.DisplayContacts();
                        break;
                    case 3:
                        book.EditContactUsingName();
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
            

        }

    }
}
