using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    class HeapSort
    {
        static void Main()
        {
            int[] salaries = { 55000, 40000, 70000, 30000, 60000 };

            int n = salaries.Length;

            for (int i = n/2- 1; i >= 0; i--)
                Sort(salaries, n, i);

            for (int i = n - 1; i > 0; i--)
            {
                int temp = salaries[0];
                salaries[0] = salaries[i];
                salaries[i] = temp;

                Sort(salaries, i, 0);
            }

            foreach (int s in salaries)
                Console.Write(s + " ");
        }

        static void Sort(int[] arr, int n, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;

            if (left < n && arr[left] > arr[largest])
                largest = left;

            if (right < n && arr[right] > arr[largest])
                largest = right;

            if (largest != i)
            {
                int temp = arr[i];
                arr[i] = arr[largest];
                arr[largest] = temp;

                Sort(arr, n, largest);
            }
        }
    }

}
