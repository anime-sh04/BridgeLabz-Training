using System;

class DuplicateChecker
{
    private int[] nums;

    public DuplicateChecker(int[] arr)
    {
        nums = arr;
    }

    public bool HasDuplicate()
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] == nums[j])
                    return true;
            }
        }
        return false;
    }
}

class Program
{
    static void Main()
    {
        int[] arr = { 3, 1, 4, 2, 5, 3 };

        DuplicateChecker checker = new DuplicateChecker(arr);

        bool result = checker.HasDuplicate();

        Console.WriteLine("Contains Duplicate: " + result);
    }
}
