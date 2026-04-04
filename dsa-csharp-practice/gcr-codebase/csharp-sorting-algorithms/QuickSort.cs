using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    class QuickSort
    {
        static void Main()
        {
            double[] prices = { 499.99, 149.50, 299.00, 99.99, 199.75 };

            Sort(prices, 0, prices.Length - 1);

            foreach (double p in prices)
                Console.Write(p + " ");
        }

        static void Sort(double[] arr, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(arr, low, high);

                Sort(arr, low, pi - 1);
                Sort(arr, pi + 1, high);
            }
        }

        static int Partition(double[] arr, int low, int high)
        {
            double pivot = arr[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    double temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            double t = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = t;

            return i + 1;
        }
    }

}
