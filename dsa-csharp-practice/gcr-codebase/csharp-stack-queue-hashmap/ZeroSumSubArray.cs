using System;
using System.Collections.Generic;

class ZeroSumSubarrays
{
    static void FindSubarrays(int[] arr)
    {
        Dictionary<int, List<int>> map = new Dictionary<int, List<int>>();

        int sum = 0;

        map[0] = new List<int> { -1 };

        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];

            if (map.ContainsKey(sum))
            {
                foreach (int startIndex in map[sum])
                {
                    Console.WriteLine($"Zero sum subarray found: {startIndex + 1} to {i}");
                }
            }

            if (!map.ContainsKey(sum))
                map[sum] = new List<int>();

            map[sum].Add(i);
        }
    }

    static void Main()
    {
        int[] arr = { 3, 4, -7, 3, 1, 3, 1, -4, -2, -2 };

        FindSubarrays(arr);
    }
}
