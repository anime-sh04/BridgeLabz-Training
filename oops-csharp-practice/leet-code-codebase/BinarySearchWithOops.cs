using System;

class BinarySearcher
{
    private int[] nums;

    // Constructor
    public BinarySearcher(int[] array)
    {
        nums = array;
    }

    // Binary Search Method
    public int Search(int target)
    {
        int left = 0;
        int right = nums.Length - 1;

        while (left <= right)
        {
            int mid = (left + right) / 2;

            if (nums[mid] == target)
                return mid;
            else if (nums[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return -1;
    }
}

class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 1, 3, 5, 7, 9 };

        BinarySearcher bs = new BinarySearcher(arr);

        int target = 5;
        int result = bs.Search(target);

        if (result != -1)
            Console.WriteLine("Element found at index: " + result);
        else
            Console.WriteLine("Element not found");
    }
}
