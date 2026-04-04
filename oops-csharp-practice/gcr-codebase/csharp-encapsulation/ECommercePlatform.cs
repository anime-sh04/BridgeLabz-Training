using System;

namespace EcommerceSystem
{
    interface ITaxable
    {
        double CalculateTax();
        string GetTaxDetails();
    }

    abstract class Product
    {
        private int productId;
        private string name;
        private double price;

        public int ProductId { get { return productId; } }
        public string Name { get { return name; } }
        public double Price { get { return price; } }

        public Product(int id, string name, double price)
        {
            productId = id;
            this.name = name;
            this.price = price;
        }
        public void SetPrice(double newPrice)
        {
            if (newPrice > 0)
                price = newPrice;
        }

        public abstract double CalculateDiscount();

        public virtual double GetFinalPrice()
        {
            return price - CalculateDiscount();
        }
    }

    class Electronics :Product,ITaxable
    {
        public Electronics(int id, string name, double price)
            : base(id, name, price) { }

        public double CalculateTax()
        {
            return Price * 0.18;
        }

        public string GetTaxDetails()
        {
            return "GST 18%";
        }

        public override double CalculateDiscount()
        {
            return Price *0.10;
        }
    }

    class Clothing :Product, ITaxable
    {
        public Clothing(int id, string name, double price)
            : base(id, name, price) { }

        public double CalculateTax()
        {
            return Price * 0.05;
        }

        public string GetTaxDetails()
        {
            return "GST 5%";
        }

        public override double CalculateDiscount()
        {
            return Price * 0.15;
        }
    }

    class Groceries :Product
    {
        public Groceries(int id, string name, double price)
            : base(id, name, price) { }

        public override double CalculateDiscount()
        {
            return Price * 0.05;
        }
    }

    class Program
    {
        static void PrintFinalPrices(Product[] products)
        {
            for (int i = 0; i < products.Length; i++)
            {
                Product p = products[i];

                double tax = 0;
                string taxInfo = "No Tax";

                if (p is ITaxable)
                {
                    ITaxable t = (ITaxable)p;
                    tax = t.CalculateTax();
                    taxInfo = t.GetTaxDetails();
                }

                double discount = p.CalculateDiscount();
                double finalPrice = p.Price + tax - discount;

                Console.WriteLine("\nProduct : " + p.Name);
                Console.WriteLine("Base Price : " + p.Price);
                Console.WriteLine("Tax : " + tax + " (" + taxInfo + ")");
                Console.WriteLine("Discount : " + discount);
                Console.WriteLine("Final Price : " + finalPrice);
            }
        }

        static void Main()
        {
            Product[] products = new Product[3];

            products[0] = new Electronics(1, "Laptop", 60000);
            products[1] = new Clothing(2, "Jacket", 3000);
            products[2] = new Groceries(3, "Rice", 1000);

            PrintFinalPrices(products);

            Console.ReadLine();
        }
    }
}
