using System;
using System.Collections.Generic;

class PairWithGivenSum
{
    static bool HasPair(int[] arr, int target)
    {
        Dictionary<int, bool> map = new Dictionary<int, bool>();

        for (int i = 0; i < arr.Length; i++)
        {
            int needed = target - arr[i];

            if (map.ContainsKey(needed))
            {
                Console.WriteLine($"Pair Found: {arr[i]} + {needed} = {target}");
                return true;
            }

            if (!map.ContainsKey(arr[i]))
                map[arr[i]] = true;
        }

        Console.WriteLine("No such pair exists.");
        return false;
    }

    static void Main()
    {
        int[] arr = { 8, 7, 2, 5, 3, 1 };
        int target = 10;

        HasPair(arr, target);
    }
}
