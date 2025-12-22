using System;

class SpringSeason
{
    static void Main(string[] args)
    {
        int month = Convert.ToInt32(Console.ReadLine());
        int day = Convert.ToInt32(Console.ReadLine());

        bool isSpring = (month == 3 && day >= 20) ||(month == 4) ||(month == 5) || (month == 6 && day <= 20);

        if (isSpring)
        {
            Console.WriteLine("Its a Spring Season");
        }
        else
        {
            Console.WriteLine("Not a Spring Season");
        }
    }
}
