using System;

class FeetToYardAndMiles
{
    static void Main(string[] args)
    {
        double Feet = Convert.ToDouble(Console.ReadLine());

        double Yards = Feet / 3;
        double Miles = Yards / 1760;

        Console.WriteLine("The distance in yards is " + Yards +" and the distance in miles is " + Miles);
    }
}
