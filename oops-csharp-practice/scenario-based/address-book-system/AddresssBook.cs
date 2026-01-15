using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace AddressBook
{
    internal class AddresssBook
    {
        private ContactPerson[] contacts = new ContactPerson[1000];
        private int count =0;

        // To add new Contact
        public void AddContact()
        {
            if (count >= 100)
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

            //ContactPerson person = new ContactPerson("Animesh", "Rajpoot", "qwer", "Mathura", "UP", "234321", 1234567, "123456");
            //ContactPerson person2 = new ContactPerson("Anuesg", "Rajpoot", "qwer", "Mathura", "UP", "234321", 1234567, "123456");
            //ContactPerson person3 = new ContactPerson("Afifa", "Rajpoot", "qwer", "Mathura", "UP", "234321", 1234567, "123456");
            contacts[count] = person;
            //contacts[count+1] = person2;
            //contacts[count+2] = person3;
            count++;    
        }

        // - UC3 Ability to edit Contacts
        public void EditContactUsingName()
        {
            Console.WriteLine("Enter the FIRST name of the person whose info you want to edit:");
            string name = Console.ReadLine();

            bool found = false;

            for (int i = 0; i < count; i++)
            {
                if (contacts[i].firstname.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    found = true;

                    Console.WriteLine("\nContact Found!");
                    Console.WriteLine(contacts[i]);
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
                            contacts[i].firstname = Console.ReadLine();
                            break;

                        case 2:
                            Console.Write("Enter new Last Name: ");
                            contacts[i].lastname = Console.ReadLine();
                            break;

                        case 3:
                            Console.Write("Enter new Address: ");
                            contacts[i].address = Console.ReadLine();
                            break;

                        case 4:
                            Console.Write("Enter new City: ");
                            contacts[i].city = Console.ReadLine();
                            break;

                        case 5:
                            Console.Write("Enter new State: ");
                            contacts[i].state = Console.ReadLine();
                            break;

                        case 6:
                            Console.Write("Enter new Zip: ");
                            contacts[i].zip = Console.ReadLine();
                            break;

                        case 7:
                            Console.Write("Enter new Phone Number: ");
                            contacts[i].phoneNumber = int.Parse(Console.ReadLine());
                            break;

                        case 8:
                            Console.Write("Enter new Email: ");
                            contacts[i].email = Console.ReadLine();
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
            for (int i = 0; i < count; i++)
            {
                if (contacts[i].firstname.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    found = true;
                    for(int j = i; j < count-1; j++)
                    {
                        contacts[j] = contacts[j+1];
                    }
                    contacts[count - 1] = null;
                    count--;
                    Console.WriteLine("Deleted Successfully");
                    return;
                }
            }
            if (!found)
            {
                Console.WriteLine("No Contact Found");
            }
        }

        // To display all Contacts
        public void DisplayContacts()
        {
            foreach(ContactPerson person in contacts)
            {
                if (person != null)
                    Console.WriteLine(person + "\n");
                else
                    return;
            }
        }
            
    }
}
