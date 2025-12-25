using System;

class SpringSeason
{
    public static bool SpringCheck(int month, int day)
    {
        if ((month == 3 && day >= 20) ||
            (month == 4) ||
            (month == 5) ||
            (month == 6 && day <= 20))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    static void Main(string[] args)
    {
        int month = int.Parse(Console.ReadLine());
        int day = int.Parse(Console.ReadLine());

        bool result = SpringCheck(month, day);

        if (result)
            Console.WriteLine("Its a Spring Season");
        else
            Console.WriteLine("Not a Spring Season");
    }
}
