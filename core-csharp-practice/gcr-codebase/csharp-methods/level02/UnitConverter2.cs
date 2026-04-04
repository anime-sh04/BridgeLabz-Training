using System;

class UnitConvertor2
{
    public static double YardsToFeet(double yards){
        double yards2feet = 3;
        return yards*yards2feet;
    }

    public static double FeetToYards(double feet){
        double feet2yards = 0.333333;
        return feet*feet2yards;
    }

    public static double MetersToInches(double meters){
        double meters2inches = 39.3701;
        return meters*meters2inches;
    }

    public static double InchesToMeters(double inches){
        double inches2meters = 0.0254;
        return inches*inches2meters;
    }

    public static double InchesToCentimeters(double inches){
        double inches2cm = 2.54;
        return inches*inches2cm;
    }

    static void Main(string[] args){
        Console.WriteLine("Enter yards to feet");
        double yards = double.Parse(Console.ReadLine());
        Console.WriteLine(YardsToFeet(yards));

        Console.WriteLine("Enter feet to yards");
        double feet = double.Parse(Console.ReadLine());
        Console.WriteLine(FeetToYards(feet));

        Console.WriteLine("Enter meters to inches");
        double meters = double.Parse(Console.ReadLine());
        Console.WriteLine(MetersToInches(meters));

        Console.WriteLine("Enter inches to Meters");
        double inches = double.Parse(Console.ReadLine());
        Console.WriteLine(InchesToMeters(inches));

        Console.WriteLine("Inches To Centimeter : ");
        Console.WriteLine(InchesToCentimeters(inches));
    }
}
