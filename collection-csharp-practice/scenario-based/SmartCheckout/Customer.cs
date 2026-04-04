using System.Collections.Generic;
namespace SmartCheckout
{
    class Customer
    {
        public string Name { get; set; }
        public List<string> Items {get; set; }

        public Customer(string name, List<string> items)
        {
            Name = name;
            Items = items;
        }   
    }   
}