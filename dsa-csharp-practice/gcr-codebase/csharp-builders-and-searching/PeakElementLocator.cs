using System;

class PeakElementLocator
{
    static void Main(string[] args)
    {
        int[] arr = { 1, 3, 20, 4, 1, 0 };

        int left = 0;
        int right = arr.Length - 1;

        while (left < right)
        {
            int mid = (left + right) / 2;

            if (arr[mid] < arr[mid + 1])
                left = mid + 1;
            else
                right = mid;
        }

        Console.WriteLine("Peak element: " + arr[left]);
        Console.WriteLine("Peak index: " + left);
    }
}
