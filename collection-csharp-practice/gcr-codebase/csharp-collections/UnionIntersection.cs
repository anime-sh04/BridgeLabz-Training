using System;
using System.Collections.Generic;

class UnionIntersection
{
    static void Main()
    {
        List<int> set1 = new List<int> {1,2,3};
        List<int> set2 = new List<int> { 3,4,5};

        List<int> union = new List<int>();
        List<int> intersection = new List<int>();

        // Union
        foreach (int x in set1)
        {
            if (!union.Contains(x))
                union.Add(x);
        }

        foreach (int x in set2)
        {
            if (!union.Contains(x))
                union.Add(x);
        }

        // Intersection
        foreach (int x in set1)
        {
            if (set2.Contains(x))
                intersection.Add(x);
        }

        Console.Write("Union: ");
        foreach (int x in union)
            Console.Write(x + " ");

        Console.WriteLine();

        Console.Write("Intersection: ");
        foreach (int x in intersection)
            Console.Write(x + " ");
    }
}
