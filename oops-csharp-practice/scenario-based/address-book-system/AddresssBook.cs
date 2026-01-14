using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            contacts[count] = person;
            count++;    
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
