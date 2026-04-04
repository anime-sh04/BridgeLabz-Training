using System;

class YoungestAndTallest
{
    static void Main(string[] args)
    {
        int amarAge = Convert.ToInt32(Console.ReadLine());
        int akbarAge = Convert.ToInt32(Console.ReadLine());
        int anthonyAge = Convert.ToInt32(Console.ReadLine());

        double amarHeight = Convert.ToDouble(Console.ReadLine());
        double akbarHeight = Convert.ToDouble(Console.ReadLine());
        double anthonyHeight = Convert.ToDouble(Console.ReadLine());

        if (amarAge < akbarAge && amarAge < anthonyAge){
            Console.WriteLine("Amar is the youngest");
        }
        else if (akbarAge < amarAge && akbarAge < anthonyAge){
            Console.WriteLine("Akbar is the youngest");
        }
        else{
            Console.WriteLine("Anthony is the youngest");
        }

        if (amarHeight > akbarHeight && amarHeight > anthonyHeight){
            Console.WriteLine("Amar is the tallest");
        }
        else if (akbarHeight > amarHeight && akbarHeight > anthonyHeight){
            Console.WriteLine("Akbar is the tallest");
        }
        else{
            Console.WriteLine("Anthony is the tallest");
        }
    }
}
