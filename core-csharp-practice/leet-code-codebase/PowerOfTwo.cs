using System;

class PowerOfThree
{
    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        bool f = true;

        if (n <= 0)
        {
            f = false;
        }
        else
        {
            while (n != 1)
            {
                if (n % 2 != 0)
                {
                    f = false;
                    break;
                }
                n = n / 2;
            }
        }
        if (f)
        {
            Console.WriteLine("It is power of 2");
        }
        else
        {
            Console.WriteLine("It is NOT");
        }
    }
}
