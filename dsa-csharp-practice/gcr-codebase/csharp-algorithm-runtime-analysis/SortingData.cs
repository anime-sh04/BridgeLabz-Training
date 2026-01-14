using System;
using System.Diagnostics;

class SortingData
{
    static void Main()
    {
        int[] sizes = { 1000, 10000, 1000000 };

        foreach (int n in sizes)
        {
            Console.WriteLine("Dataset Size: "+n);

            int[] data1 = GenerateData(n);
            int[] data2 = (int[])data1.Clone();
            int[] data3 = (int[])data1.Clone();

            Stopwatch sw = new Stopwatch();

            if (n <= 10000) // Bubble sort is too slow for large data
            {
                sw.Start();
                BubbleSort(data1);
                sw.Stop();
                Console.WriteLine("Bubble Sort: "+sw.ElapsedMilliseconds+" ms");
                sw.Reset();
            }
            else
                Console.WriteLine("Bubble Sort: Skipped (Too Slow)");

            sw.Start();
            MergeSort(data2, 0, data2.Length - 1);
            sw.Stop();
            Console.WriteLine("Merge Sort: "+sw.ElapsedMilliseconds+" ms");
            sw.Reset();

            sw.Start();
            QuickSort(data3, 0, data3.Length - 1);
            sw.Stop();
            Console.WriteLine("Quick Sort: "+sw.ElapsedMilliseconds+" ms");
        }

        Console.ReadLine();
    }

    static int[] GenerateData(int n)
    {
        Random r = new Random();
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
            arr[i] = r.Next();
        return arr;
    }

    static void BubbleSort(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
            for (int j = 0; j < arr.Length - i - 1; j++)
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
    }

    static void MergeSort(int[] arr, int left, int right)
    {
        if (left >= right) return;

        int mid = (left + right) / 2;
        MergeSort(arr, left, mid);
        MergeSort(arr, mid + 1, right);
        Merge(arr, left, mid, right);
    }

    static void Merge(int[] arr, int left, int mid, int right)
    {
        int[] temp = new int[right - left + 1];
        int i = left, j = mid + 1, k = 0;

        while (i <= mid && j <= right)
            temp[k++] = arr[i] <= arr[j] ? arr[i++] : arr[j++];

        while (i <= mid) temp[k++] = arr[i++];
        while (j <= right) temp[k++] = arr[j++];

        for (int x = 0; x < temp.Length; x++)
            arr[left + x] = temp[x];
    }

    static void QuickSort(int[] arr, int low, int high)
    {
        if (low >= high) return;

        int pivot = Partition(arr, low, high);
        QuickSort(arr, low, pivot - 1);
        QuickSort(arr, pivot + 1, high);
    }

    static int Partition(int[] arr, int low, int high)
    {
        int pivot = arr[high];
        int i = low - 1;

        for (int j = low; j < high; j++)
            if (arr[j] < pivot)
            {
                i++;
                arr[i] = arr[j];
				arr[j] = arr[i];
            }

        arr[i + 1] = arr[high];
		arr[high] =arr[i + 1];
        return i + 1;
    }
}
