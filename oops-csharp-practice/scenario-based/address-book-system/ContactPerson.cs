using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class ContactPerson
    {
        private string FirstName;
        private string LastName;
        private string Address;
        private string City;
        private string State;
        private string Zip;
        private long PhoneNumber;
        private string Email;

        public ContactPerson(string firstName, string lastName, string address, string city, string state, string zip, long phoneNumber, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            City = city;
            State = state;
            Zip = zip;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public override string? ToString()
        {
            return $"First Name: {FirstName}\nLast Name: {LastName}\nAddress: {Address}\nCity: {City}\nState: {State}\nZip: {Zip}\nPhone Number: {PhoneNumber}\nEmail: {Email}";
        }
    }
}
