using System;

namespace FlashDealz
{
    class ProductUtilityImpl : IProduct
    {
        Product[] products = new Product[10];
        int count = 0;

        public void AddProduct()
        {
            Console.WriteLine("Enter Product Name:");
            string name = Console.ReadLine();

            Console.WriteLine($"Enter Discounted Price of {name}:");
            double discountedPrice = double.Parse(Console.ReadLine());

            products[count] = new Product(name, discountedPrice);
            count++;

            Console.WriteLine("Product Added Successfully\n");
        }

        public void DisplaySortedProducts()
        {
            if (count > 1)
            {
                QuickSort(products, 0, count -1);
            }
            DisplayProducts();
        }
        
        void QuickSort(Product[] arr, int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = Partition(arr, low, high);

                QuickSort(arr, low, pivotIndex - 1);
                QuickSort(arr, pivotIndex + 1, high);
            }
        }


        int Partition(Product[] arr, int low, int high)
        {
            double pivot = arr[high].DiscountedPrice;
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (arr[j].DiscountedPrice < pivot)
                {
                    i++;
                    Swap(arr, i, j);
                }
            }

            Swap(arr, i + 1, high);
            return i + 1;
        }

        void Swap(Product[] arr, int i, int j)
        {
            Product temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        public void DisplayProducts()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(products[i]);
            }
            Console.WriteLine();
        }
    }
}
