using System;
using System.Collections.Generic;

class RotateElements
{
    static void Main()
    {
        RotateElements r = new RotateElements();
        List<int> l = new List<int> {10,20,30,40,50};

        Console.Write("Rotate By: ");
        int k = int.Parse(Console.ReadLine());

        k = k % l.Count; // handle large rotations

        r.Reverse(l,0,k - 1);
        r.Reverse(l,k,l.Count -1);
        r.Reverse(l,0,l.Count -1);
        
        foreach (int i in l)
        {
            Console.Write(i + " ");
        }
    }

    void Reverse(List<int> l, int start, int end)
    {
        while (start < end)
        {
            int temp = l[start];
            l[start] = l[end];
            l[end] = temp;

            start++;
            end--;
        }
    }
}
