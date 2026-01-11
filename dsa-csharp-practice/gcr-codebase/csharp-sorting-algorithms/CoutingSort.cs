using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    class CountingSort
    {
        static void Main()
        {
            int[] ages = { 12, 15, 10, 18, 14, 11, 13, 16, 12, 15, 10 };

            int min = 10, max = 18;
            int range = max - min + 1;

            int[] count = new int[range];
            int[] output = new int[ages.Length];

            for (int i = 0; i < ages.Length; i++)
                count[ages[i] - min]++;

            for (int i = 1; i < range; i++)
                count[i] += count[i - 1];

            for (int i = ages.Length - 1; i >= 0; i--)
            {
                int index = ages[i] - min;
                output[count[index] - 1] = ages[i];
                count[index]--;
            }

            for (int i = 0; i < ages.Length; i++)
                ages[i] = output[i];

            foreach (int a in ages)
                Console.Write(a + " ");
        }
    }

}
