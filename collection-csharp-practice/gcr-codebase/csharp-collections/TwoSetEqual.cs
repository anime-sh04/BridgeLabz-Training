using System;
using System.Collections.Generic;

class TwoSetEqual
{
    static void Main()
    {
        List<int> set1 = new List<int> {1,2,3};
        List<int> set2 = new List<int> {3,2,1};

        bool result = IsEqual(set1, set2);

        Console.WriteLine(result);
    }

    static bool IsEqual(List<int> a, List<int> b)
    {
        if (a.Count != b.Count)
            return false;

        a.Sort();
        b.Sort();

        for (int i = 0; i < a.Count; i++)
        {
            if (a[i] != b[i])
                return false;
        }

        return true;
    }
}
