using System;

namespace FoodDeliverySystem
{
    interface IDiscountable
    {
        double ApplyDiscount();
        string GetDiscountDetails();
    }

    abstract class FoodItem
    {
        private string itemName;
        private double price;
        private int quantity;

        public string ItemName { get { return itemName; } }
        public double Price { get { return price; } }
        public int Quantity { get { return quantity; } }

        public FoodItem(string name, double price, int qty)
        {
            itemName = name;
            this.price = price;
            quantity = qty;
        }

        public abstract double CalculateTotalPrice();

        public void GetItemDetails()
        {
            Console.WriteLine("Item : " + ItemName);
            Console.WriteLine("Price : " + Price);
            Console.WriteLine("Quantity : " + Quantity);
        }
    }

    class VegItem : FoodItem, IDiscountable
    {
        public VegItem(string name, double price, int qty)
            : base(name, price, qty) { }

        public override double CalculateTotalPrice()
        {
            return Price * Quantity;
        }

        public double ApplyDiscount()
        {
            return Price* Quantity * 0.10;
        }

        public string GetDiscountDetails()
        {
            return "10% VegDiscount";
        }
    }

    class NonVegItem : FoodItem, IDiscountable
    {
        public NonVegItem(string name, double price, int qty)
            : base(name, price, qty) { }

        public override double CalculateTotalPrice()
        {
            return (Price*Quantity) + 50;
        }

        public double ApplyDiscount()
        {
            return Price *Quantity *0.05;
        }

        public string GetDiscountDetails()
        {
            return "5% Non-Veg Discount";
        }
    }

    class Program
    {
        static void Main()
        {
            FoodItem[] order = new FoodItem[2];
            order[0] = new VegItem("Pizza", 300, 2);
            order[1] = new NonVegItem("Chicken",200, 3);

            for (int i = 0; i < order.Length; i++)
            {
                FoodItem item = order[i];
                item.GetItemDetails();

                double total = item.CalculateTotalPrice();

                double discount = 0;
                string discountInfo = "No Discount";

                if (item is IDiscountable)
                {
                    IDiscountable d = (IDiscountable)item;
                    discount = d.ApplyDiscount();
                    discountInfo = d.GetDiscountDetails();
                }

                Console.WriteLine("Total Price : " + total);
                Console.WriteLine("Discount : " + discount + " (" + discountInfo + ")");
                Console.WriteLine("Final Bill : " + (total - discount));
            }
        }
    }
}
