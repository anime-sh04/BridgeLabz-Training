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
                Console.WriteLine("1. Add Contact");              // UC-1,2 Ability to create and add contacts
                Console.WriteLine("2. Display Contacts");         // Bonus
                Console.WriteLine("3. Edit Contact");             // UC-3 Ability to Edit a Contact
                Console.WriteLine("4. Delete Contact");           // UC-4 Ability to Delete a Contact
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
                    case 4:
                        book.DeleteContactUsingName();
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
            

        }

    }
}
