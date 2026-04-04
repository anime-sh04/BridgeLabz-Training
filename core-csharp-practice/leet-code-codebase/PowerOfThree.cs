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
                if (n % 3 != 0)
                {
                    f = false;
                    break;
                }
                n = n / 3;
            }
        }
        if (f)
        {
            Console.WriteLine("It is power of 3");
        }
        else
        {
            Console.WriteLine("It is NOT");
        }
    }
}
