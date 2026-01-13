using System;

class MissingNumberFinder
{
    private int[] nums;

    public MissingNumberFinder(int[] arr)
    {
        nums = arr;
    }

    public int FindMissing()
    {
        int n = nums.Length;
        int expectedSum = n * (n + 1) / 2;
        int actualSum = 0;

        for (int i = 0; i < n; i++)
            actualSum += nums[i];

        return expectedSum - actualSum;
    }
}

class Program
{
    static void Main()
    {
        int[] arr = { 3, 0, 1 };

        MissingNumberFinder finder = new MissingNumberFinder(arr);

        int result = finder.FindMissing();

        Console.WriteLine("Missing Number: " + result);
    }
}
