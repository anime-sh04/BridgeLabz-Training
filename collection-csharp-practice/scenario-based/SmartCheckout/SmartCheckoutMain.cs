using System;
using System.Collections.Generic;
namespace SmartCheckout
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, Item> inventory = new Dictionary<string, Item>(){{ "Bread", new Item(30, 15) },,{ "Eggs",  new Item(6, 100) },{ "Oil",   new Item(180, 10) },{ "Rice",  new Item(60, 25) }};

            Queue<Customer> checkoutQueue = new Queue<Customer>();

            checkoutQueue.Enqueue(new Customer("Animesh",new List<string> { "Milk", "Bread", "Eggs" }));
            checkoutQueue.Enqueue(new Customer("Aniubhav",new List<string> { "Rice", "Oil" }));
            checkoutQueue.Enqueue(new Customer("Afifa",new List<string> { "Milk", "Eggs", "Eggs" }));

        
            Console.WriteLine("Smart Checkout Billing System\n");

            while(checkoutQueue.Count > 0)
            {
                Customer current = checkoutQueue.Dequeue();
                Console.WriteLine($"Customer: {current.Name}");
                double total = 0;
                foreach (string itemName in current.Items)
                {
                    if (inventory.ContainsKey(itemName))
                    {
                        Item item = inventory[itemName];

                        if (item.Quantity> 0)
                        {
                            total += item.Price;
                            item.Quantity--;

                            Console.WriteLine($"{itemName} -₹{item.Price}(Quantity left: {item.Quantity})");
                        }
                        else
                        {
                            Console.WriteLine($"{itemName} - OUT OF Quantity");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{itemName} - ITEM NOT FOUND");
                    }
                }
                Console.WriteLine($"Total Price: ₹{total}");
            }
        }
    }
}