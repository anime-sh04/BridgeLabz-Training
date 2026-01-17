
using System;
namespace FlashDealz {

    
    class ProductMenu
    {
        IProduct product = new ProductUtilityImpl();
        public void Menu()
        {
            while (true)
            {
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. Sort And Display Product");
                Console.WriteLine("3. Display Products");
                Console.WriteLine("0. Exit");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1: product.AddProduct();break;
                    case 2: product.DisplaySortedProducts();break;
                    case 3: product.DisplayProducts();break;
                    case 0: return;
                    default:Console.WriteLine("Invalid Choice");break;
                }
            }
        }
    }
}