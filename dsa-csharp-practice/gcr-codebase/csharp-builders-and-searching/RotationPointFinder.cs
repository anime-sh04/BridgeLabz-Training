using System;

class RotationPointFinder
{
    static void Main(string[] args)
    {
        int[] arr = { 15, 18, 2, 3, 6, 12 };

        int left = 0;
        int right = arr.Length - 1;

        while (left < right)
        {
            int mid = (left + right) / 2;

            if (arr[mid] > arr[right])
                left = mid + 1;
            else
                right = mid;
        }

        Console.WriteLine("Rotation point index: " + left);
        Console.WriteLine("Smallest element: " + arr[left]);
    }
}
