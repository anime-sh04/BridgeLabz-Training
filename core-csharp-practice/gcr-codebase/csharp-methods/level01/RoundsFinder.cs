using System;

class RoundsFinder
{
    public static double CalculateRounds(double side1, double side2, double side3){
        double perimeter = side1+side2+side3;
        double distance = 5000;

        double rounds = distance/perimeter;
        return rounds;
    }

    static void Main(string[] args){
        double side1 = double.Parse(Console.ReadLine());
        double side2 = double.Parse(Console.ReadLine());
        double side3 = double.Parse(Console.ReadLine());

        double result = CalculateRounds(side1, side2, side3);

        Console.WriteLine(result);
    }
}
