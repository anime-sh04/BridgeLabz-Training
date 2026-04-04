using System;

class FirstNegativeFinder
{
    static void Main(string[] args)
    {
        int[] arr = { 5, 8, 2, -3, 7, -9, 4 };

        int index = -1;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < 0)
            {
                index = i;
                break;
            }
        }

        if (index != -1)
            Console.WriteLine("First negative number: " + arr[index]);
        else
            Console.WriteLine("No negative number found");
    }
}
