using System;

class AvgOfThreeNumber
{
    public static void Main(string[] args)
    {
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine((a + b + c) / 3.0);
    }
}
