using System;

class Program
{
    static void Main()
    {
        int[] nums = { 4, 1, 2, 1, 2 };

        int result = SingleNumber(nums);

        Console.WriteLine("Single Number is: " + result);
    }

    static int SingleNumber(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            int count = 0;

            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[i] == nums[j])
                {
                    count++;
                }
            }

            if (count == 1)
                return nums[i];
        }

        return -1;
    }
}
