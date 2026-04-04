using System;
namespace SmartCheckout
{
    class Item
    {
        public double Price { get; set; }
        public int Quantity{ get; set; }

        public Item(double price, int quantity)
        {
            Price = price;
            Quantity = quantity;
        }
    }

    
}