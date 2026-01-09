using System;
using System.Collections.Generic;

class TwoSum
{
    static int[] FindTwoSum(int[] nums, int target)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int needed = target - nums[i];

            if (map.ContainsKey(needed))
            {
                return new int[] { map[needed], i };
            }

            if (!map.ContainsKey(nums[i]))
                map[nums[i]] = i;
        }

        return new int[] { -1, -1 };
    }

    static void Main()
    {
        int[] nums = { 2, 7, 11, 15 };
        int target = 9;

        int[] ans = FindTwoSum(nums, target);

        Console.WriteLine("Indices: " + ans[0] + ", " + ans[1]);
    }
}
