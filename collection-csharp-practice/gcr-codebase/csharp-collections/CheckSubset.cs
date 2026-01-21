using System;
using System.Collections.Generic;

class SubsetCheck
{
    static void Main()
    {
        List<int> setA = new List<int> {2,3};
        List<int> setB = new List<int> {1,2,3,4};

        bool isSubset = true;

        foreach (int x in setA)
        {
            if (!setB.Contains(x))
            {
                isSubset = false;
                break;
            }
        }

        Console.WriteLine(isSubset);
    }
}
