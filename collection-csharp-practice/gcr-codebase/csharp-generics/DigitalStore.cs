using System;
using System.Collections.Generic;

namespace DigitalStore
{
    // Abstract base class
    abstract class ProductCategory
    {
        public string Name { get; protected set; }
        public double Price { get; protected set; }

        protected ProductCategory(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public void ApplyPriceReduction(double percent)
        {
            Price -= Price * percent / 100;
        }

        public abstract void ShowDetails();
    }

    // Book category
    class BookItem : ProductCategory
    {
        public string Title { get; private set; }
        public string Genre { get; private set; }

        public BookItem(string name, double price, string title, string genre)
            : base(name, price)
        {
            Title = title;
            Genre = genre;
        }

        public override void ShowDetails()
        {
            Console.WriteLine($"Category: {Name}, Book: {Title}, Genre: {Genre}, Price: {Price}");
        }
    }

    // Clothing category
    class ClothingItem : ProductCategory
    {
        public string Type { get; private set; }
        public string Size { get; private set; }

        public ClothingItem(string name, double price, string type, string size)
            : base(name, price)
        {
            Type = type;
            Size = size;
        }

        public override void ShowDetails()
        {
            Console.WriteLine($"Category: {Name}, Item: {Type}, Size: {Size}, Price: {Price}");
        }
    }

    // Generic product handler
    class Inventory<T> where T : ProductCategory
    {
        private List<T> items = new List<T>();

        public void AddItem(T item)
        {
            items.Add(item);
        }

        public void DiscountItem(T item, double percent)
        {
            item.ApplyPriceReduction(percent);
        }

        public void DisplayInventory()
        {
            foreach (var item in items)
            {
                item.ShowDetails();
            }
        }
    }

    class Program
    {
        static void Main()
        {
            var bookInventory = new Inventory<BookItem>();
            var book = new BookItem("Books", 20.0, "The Great Gatsby", "Fiction");
            bookInventory.AddItem(book);
            bookInventory.DiscountItem(book, 10);
            bookInventory.DisplayInventory();

            var clothingInventory = new Inventory<ClothingItem>();
            var cloth = new ClothingItem("Clothing", 50.0, "T-Shirt", "M");
            clothingInventory.AddItem(cloth);
            clothingInventory.DiscountItem(cloth, 15);
            clothingInventory.DisplayInventory();
        }
    }
}
