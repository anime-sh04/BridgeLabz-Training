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

        public string firstname { get { return FirstName; } set { FirstName = value; } }
        public string lastname { get { return LastName; } set { LastName = value; } }
        public string address { get { return Address; } set { Address = value; } }
        public string city { get { return City; } set { City = value; } }
        public string state { get { return State; } set { State = value; } }
        public string zip { get { return Zip; } set { Zip = value; } }
        public long phoneNumber { get { return PhoneNumber; } set { PhoneNumber = value; } }
        public string email { get { return Email; } set { Email = value; } }

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
