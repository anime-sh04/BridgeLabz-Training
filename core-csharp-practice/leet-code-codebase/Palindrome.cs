using System;

class Palindrome
{
    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int i = n;
        int r = 0;

        while(n>0)
        {
            int d = n % 10;
            r = r*10 +d;
            n = n/10;
        }

        if(i== r)
        {
            Console.WriteLine("It is Plain");
        }
        else
        {
            Console.WriteLine("Its not");
        }
    }
}
