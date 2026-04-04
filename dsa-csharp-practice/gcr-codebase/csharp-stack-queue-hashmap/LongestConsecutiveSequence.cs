using System;
using System.Collections.Generic;

class LongestConsecutiveSequence
{
    static int FindLongest(int[] arr)
    {
        HashSet<int> set = new HashSet<int>();

        foreach (int x in arr)
            set.Add(x);

        int longest = 0;

        foreach (int x in arr)
        {
            if (!set.Contains(x - 1))
            {
                int current = x;
                int count = 1;

                while (set.Contains(current + 1))
                {
                    current++;
                    count++;
                }

                longest = Math.Max(longest, count);
            }
        }

        return longest;
    }

    static void Main()
    {
        int[] arr = { 100, 4, 200, 1, 3, 2 };
        int ans = FindLongest(arr);

        Console.WriteLine("Longest Consecutive Sequence Length: " + ans);
    }
}
