using System;
using System.Diagnostics;

class SearchATarget
{
    static void Main(string[] args)
    {
        int[] sizes = { 1000, 10000, 1000000 };
        int target = -1;   //Worst case

        foreach (int n in sizes)
        {
            Console.WriteLine("Dataset Size: "+n);

            int[] data = GenerateData(n);

            // Linear Search
            Stopwatch sw = Stopwatch.StartNew();
            LinearSearch(data, target);
            sw.Stop();
            Console.WriteLine("Linear Search Time: "+sw.ElapsedMilliseconds+" ms");

            // Sorting for Binary Search
            sw.Restart();
            Array.Sort(data);
            sw.Stop();
            Console.WriteLine("Sorting Time: "+sw.ElapsedMilliseconds+" ms");

            // Binary Search
            sw.Restart();
            BinarySearch(data, target);
            sw.Stop();
            Console.WriteLine("Binary Search Time: "+sw.ElapsedMilliseconds+" ms");
        }
    }

    static int[] GenerateData(int n)
    {
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
            arr[i] = i;
        return arr;
    }

    static int LinearSearch(int[] arr, int target)
    {
        for (int i = 0; i < arr.Length; i++)
            if (arr[i] == target)
                return i;
        return -1;
    }

    static int BinarySearch(int[] arr, int target)
    {
        int left =0, right =arr.Length - 1;

        while (left <=right)
        {
            int mid = (left + right) / 2;

            if (arr[mid] == target)
                return mid;
            else if (arr[mid] < target)
                left = mid+1;
            else
                right = mid- 1;
        }
        return -1;
    }
}
