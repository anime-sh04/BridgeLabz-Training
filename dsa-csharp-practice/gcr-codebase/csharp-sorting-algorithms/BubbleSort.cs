namespace Algo
{
    internal class BubbleSort
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 1, 7, 8, 10 };

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            foreach(int i in arr)
            {
                Console.Write(i + " ");   
            }
        }
    }
}
