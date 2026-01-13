using System;

class OccurrenceRangeFinder
{
    static void Main(string[] args)
    {
        int[] arr = { 2, 4, 4, 4, 6, 7, 8 };
        int target = 4;

        int first = FindFirst(arr, target);
        int last = FindLast(arr, target);

        if (first == -1)
            Console.WriteLine("Element not found");
        else
            Console.WriteLine("First occurrence: " + first + "\nLast occurrence: " + last);
    }

    static int FindFirst(int[] arr, int target)
    {
        int left = 0, right = arr.Length - 1;
        int result = -1;

        while (left <= right)
        {
            int mid = (left + right) / 2;

            if (arr[mid] == target)
            {
                result = mid;
                right = mid - 1;
            }
            else if (arr[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return result;
    }

    static int FindLast(int[] arr, int target)
    {
        int left = 0, right = arr.Length - 1;
        int result = -1;

        while (left <= right)
        {
            int mid = (left + right) / 2;

            if (arr[mid] == target)
            {
                result = mid;
                left = mid + 1;
            }
            else if (arr[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return result;
    }
}
