using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    class InsertionSort
    {
        static void Main()
        {
            int[] employeeIds = { 104, 102, 109, 101, 105 };

            for (int i =1; i <employeeIds.Length; i++)
            {
                int key = employeeIds[i];
                int j = i-1;

                while (j >=0 && employeeIds[j]>key)
                {
                    employeeIds[j +1] = employeeIds[j];
                    j--;
                }

                employeeIds[j +1] = key;
            }

            foreach (int id in employeeIds)
                Console.Write(id + " ");
        }
    }

}
