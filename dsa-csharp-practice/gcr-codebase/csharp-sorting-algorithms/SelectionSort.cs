using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    class SelectionSort
    {
        static void Main()
        {
            int[] scores = { 78, 92, 85, 67, 90, 73 };

            for (int i = 0; i < scores.Length - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < scores.Length; j++)
                {
                    if (scores[j] < scores[minIndex])
                        minIndex = j;
                }

                int temp = scores[minIndex];
                scores[minIndex] = scores[i];
                scores[i] = temp;
            }

            foreach (int s in scores)
                Console.Write(s + " ");
        }
    }

}
