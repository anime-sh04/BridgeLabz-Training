using System;
using System.Collections.Generic;

class SymmetricDifference
{
    static void Main()
    {
        List<int> set1 = new List<int> { 1, 2, 3 };
        List<int> set2 = new List<int> { 3, 4, 5 };

        List<int> result = new List<int>();
        foreach (int x in set1)
        {
            if (!set2.Contains(x))
                result.Add(x);
        }


        foreach (int x in set2)
        {
            if (!set1.Contains(x))
                result.Add(x);
        }

        Console.Write("Output: ");
        foreach (int x in result)
            Console.Write(x + " ");
    }
}
