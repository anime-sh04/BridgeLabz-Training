using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace AddressBook
{
    internal class AddresssBookUtilityImp : IAddressBook
    {
        private AddresssBook currentBook;

        public AddresssBookUtilityImp(AddresssBook book)
        {
            currentBook = book;
        }


        // To add new Contact
        public void AddContact()
        {
            if (currentBook.Count >= 100)
            {
                Console.WriteLine("Contact Book is Full");
                return;
            }

            // Adding Contact 
            // - UC1 Ability to create Contacts

            //ContactPerson person = new ContactPerson("Animesh", "Rajpoot", "qwer", "Mathura", "UP", "234321", 1234567, "123456");

            // - UC2 Ability to add new Contacts to address book

            Console.WriteLine("Enter First Name:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter Last Name:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter Address:");
            string address = Console.ReadLine();

            Console.WriteLine("Enter City:");
            string city = Console.ReadLine();

            Console.WriteLine("Enter State:");
            string state = Console.ReadLine();

            Console.WriteLine("Enter Zip:");
            string zip = Console.ReadLine();

            Console.WriteLine("Enter Phone Number:");
            long phoneNumber = long.Parse(Console.ReadLine());

            Console.WriteLine("Enter Email:");
            string email = Console.ReadLine();

            ContactPerson person = new ContactPerson(firstName, lastName, address, city, state, zip, phoneNumber, email);

            for (int i = 0; i < currentBook.Count; i++)    // - UC7 Ability to check duplicate contact and reject them
            {
                if (currentBook.Contacts[i].Equals(person))
                {
                    Console.WriteLine("Duplicate contact! This person already exists in the Address Book.");
                    return;
                }
            }

            currentBook.Contacts[currentBook.Count] = person;


            //ContactPerson person = new ContactPerson("Animesh", "Rajpoot", "qwer", "Mathura", "UP", "234321", 1234567, "123456");
            //ContactPerson person2 = new ContactPerson("Anuesg", "Rajpoot", "qwer", "Mathura", "UP", "234321", 1234567, "123456");
            //ContactPerson person3 = new ContactPerson("Afifa", "Rajpoot", "qwer", "Mathura", "UP", "234321", 1234567, "123456");
            //currentBook.Contacts[currentBook.Count+1] = person2;
            //currentBook.Contacts[currentBook.Count+2] = person3;
            currentBook.Count++;
            Console.WriteLine("Added Contact Successfully");
        }

        // - UC3 Ability to edit Contacts
        public void EditContactUsingName()
        {
            Console.WriteLine("Enter the FIRST name of the person whose info you want to edit:");
            string name = Console.ReadLine();

            bool found = false;

            for (int i = 0; i < currentBook.Count; i++)
            {
                if (currentBook.Contacts[i].firstname.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    found = true;

                    Console.WriteLine("\nContact Found!");
                    Console.WriteLine(currentBook.Contacts[i]);
                    Console.WriteLine("What would you like to edit?");
                    Console.WriteLine("1. First Name");
                    Console.WriteLine("2. Last Name");
                    Console.WriteLine("3. Address");
                    Console.WriteLine("4. City");
                    Console.WriteLine("5. State");
                    Console.WriteLine("6. Zip");
                    Console.WriteLine("7. Phone Number");
                    Console.WriteLine("8. Email");

                    int toEdit = int.Parse(Console.ReadLine());

                    switch (toEdit)
                    {
                        case 1:
                            Console.Write("Enter new First Name: ");
                            currentBook.Contacts[i].firstname = Console.ReadLine();
                            break;

                        case 2:
                            Console.Write("Enter new Last Name: ");
                            currentBook.Contacts[i].lastname = Console.ReadLine();
                            break;

                        case 3:
                            Console.Write("Enter new Address: ");
                            currentBook.Contacts[i].address = Console.ReadLine();
                            break;

                        case 4:
                            Console.Write("Enter new City: ");
                            currentBook.Contacts[i].city = Console.ReadLine();
                            break;

                        case 5:
                            Console.Write("Enter new State: ");
                            currentBook.Contacts[i].state = Console.ReadLine();
                            break;

                        case 6:
                            Console.Write("Enter new Zip: ");
                            currentBook.Contacts[i].zip = Console.ReadLine();
                            break;

                        case 7:
                            Console.Write("Enter new Phone Number: ");
                            currentBook.Contacts[i].phoneNumber = int.Parse(Console.ReadLine());
                            break;

                        case 8:
                            Console.Write("Enter new Email: ");
                            currentBook.Contacts[i].email = Console.ReadLine();
                            break;

                        default:
                            Console.WriteLine("Invalid option.");
                            return;
                    }

                    Console.WriteLine("\nContact edited successfully!");
                    return;
                }
            }

            if (!found)
            {
                Console.WriteLine("\nNo contact found with that name.");
            }
        }


        // - UC4 Ability to Delete Contacts
        public void DeleteContactUsingName()
        {
            Console.WriteLine("Enter the FIRST name of the person whose contact you want to delete:");
            string name = Console.ReadLine();
            bool found = false;
            for (int i = 0; i < currentBook.Count; i++)
            {
                if (currentBook.Contacts[i].firstname.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    found = true;
                    for (int j = i; j < currentBook.Count - 1; j++)
                    {
                        currentBook.Contacts[j] = currentBook.Contacts[j + 1];
                    }
                    currentBook.Contacts[currentBook.Count - 1] = null;
                    currentBook.Count--;
                    Console.WriteLine("Deleted Successfully");
                    return;
                }
            }
            if (!found)
            {
                Console.WriteLine("No Contact Found");
            }
        }

        // - UC5 Ability to Add Multiple Contacts
        public void AddMultipleContacts()
        {
            while (true)
            {
                AddContact();
                Console.WriteLine("Do you want to add more currentBook.Contacts? Enter Y if yes else any other key..");
                string choice = Console.ReadLine();
                if (choice == "Y")
                {
                    continue;
                }
                else { return; }
            }
        }

        // UC-11 Ability to sort the entries in the address book alphabetically by Person’s name
        public void SortContactsByName()
        {
            if (currentBook.Count == 0)
            {
                Console.WriteLine("No contacts to sort.");
                return;
            }

            // using Bubble Sort
            for (int i = 0; i < currentBook.Count - 1; i++)
            {
                for (int j = 0; j < currentBook.Count - i-1; j++)
                {
                    if (string.Compare(currentBook.Contacts[j].firstname,currentBook.Contacts[j + 1].firstname,StringComparison.OrdinalIgnoreCase) > 0)
                    {
                        // swap
                        ContactPerson temp = currentBook.Contacts[j];
                        currentBook.Contacts[j] = currentBook.Contacts[j + 1];
                        currentBook.Contacts[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("\nContacts sorted alphabetically by First Name:");

            for (int i = 0; i <currentBook.Count; i++)
            {
                Console.WriteLine(currentBook.Contacts[i]);
                Console.WriteLine();
            }
        }


        // To display all Contacts
        public void DisplayContacts()
        {
            foreach (ContactPerson person in currentBook.Contacts)
            {
                if (person != null)
                    Console.WriteLine(person + "\n");
                else
                    return;
            }
        }

    }
}
