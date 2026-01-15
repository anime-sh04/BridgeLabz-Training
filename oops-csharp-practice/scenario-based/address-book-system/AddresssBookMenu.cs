using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AddressBook
{
    internal class AddresssBookMenu
    {
        private AddresssBook[] books = new AddresssBook[20];  // - UC6 Added Multiple Address Books
        private int bookCount = 0;

        private AddresssBook currentBook;
        private AddresssBookUtilityImp utility;

        public void Start()
        {
            while (true)
            {
                Console.WriteLine("\n===== ADDRESS BOOK SYSTEM =====");
                Console.WriteLine("1. Create New Address Book");
                Console.WriteLine("2. Open Address Book");
                Console.WriteLine("0. Exit");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 0: return;

                    case 1:
                        CreateAddressBook();
                        break;

                    case 2:
                        OpenAddressBook();
                        break;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }

        private void CreateAddressBook()   // - UC6 Added Multiple Address Books
        {
            Console.Write("Enter new Address Book name: ");
            string name = Console.ReadLine();

            for (int i = 0; i < bookCount; i++)
                if (books[i].BookName.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Address Book already exists!");
                    return;
                }

            books[bookCount++] = new AddresssBook(name);
            Console.WriteLine("Address Book created successfully!");
        }

        private void OpenAddressBook()    // - UC6 Added Multiple Address Books
        {
            if (bookCount == 0)
            {
                Console.WriteLine("No Address Books available.");
                return;
            }

            Console.WriteLine("\nAvailable Address Books:");
            for (int i = 0; i < bookCount; i++)
                Console.WriteLine($"{i+1}. {books[i].BookName}");

            Console.Write("Select Address Book number: ");
            int index = int.Parse(Console.ReadLine()) - 1;

            if (index < 0 || index >= bookCount)
            {
                Console.WriteLine("Invalid selection.");
                return;
            }

            currentBook = books[index];
            utility = new AddresssBookUtilityImp(currentBook);

            AddressBookOperationsMenu();
        }

        private void AddressBookOperationsMenu()
        {
            while (true)
            {
                Console.WriteLine("\n===== ADDRESS BOOK: " + currentBook.BookName + " =====");
                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. Display Contacts");
                Console.WriteLine("3. Edit Contact");
                Console.WriteLine("4. Delete Contact");
                Console.WriteLine("5. Add Multiple Contacts");
                Console.WriteLine("0. Back");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 0: return;
                    case 1: utility.AddContact(); break;
                    case 2: utility.DisplayContacts(); break;
                    case 3: utility.EditContactUsingName(); break;
                    case 4: utility.DeleteContactUsingName(); break;
                    case 5: utility.AddMultipleContacts(); break;
                    default: Console.WriteLine("Invalid Choice"); break;
                }
            }
        }
    }
}
