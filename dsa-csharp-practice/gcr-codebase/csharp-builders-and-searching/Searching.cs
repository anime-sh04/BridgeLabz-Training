using System;
using System.Linq;

class Searching
{
    static void Main(string[] args)
    {
        int[] arr = { 3, 4, -1, 1, 7, 2 };
        int target = 7;

        int missing = FindFirstMissingPositive(arr);
        Console.WriteLine("First missing positive: " + missing);

        Array.Sort(arr);

        int index = BinarySearch(arr, target);

        if (index != -1)
            Console.WriteLine("Target index after sorting: " + index);
        else
            Console.WriteLine("Target not found");
    }

    static int FindFirstMissingPositive(int[] arr)
    {
        bool[] visited = new bool[arr.Length + 1];

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > 0 && arr[i] <= arr.Length)
                visited[arr[i]] = true;
        }

        for (int i = 1; i <= arr.Length; i++)
        {
            if (!visited[i])
                return i;
        }

        return arr.Length + 1;
    }

    static int BinarySearch(int[] arr, int target)
    {
        int left = 0;
        int right = arr.Length - 1;

        while (left <= right)
        {
            int mid = (left + right) / 2;

            if (arr[mid] == target)
                return mid;

            if (arr[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return -1;
    }
}
