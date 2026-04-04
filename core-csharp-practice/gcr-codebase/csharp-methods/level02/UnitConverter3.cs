using System;

class UnitConvertor
{
    public static double FarhenheitToCelsius(double farhenheit){
        double farhenheit2celsius = (farhenheit-32)* 5/9;
        return farhenheit2celsius;
    }

    public static double CelsiusToFarhenheit(double celsius){
        double celsius2farhenheit = (celsius*9/5)+ 32;
        return celsius2farhenheit;
    }

    public static double PoundsToKilograms(double pounds){
        double pounds2kilograms = 0.453592;
        return pounds * pounds2kilograms;
    }

    public static double KilogramsToPounds(double kilograms){
        double kilograms2pounds = 2.20462;
        return kilograms * kilograms2pounds;
    }

    public static double GallonsToLiters(double gallons){
        double gallons2liters = 3.78541;
        return gallons * gallons2liters;
    }

    public static double LitersToGallons(double liters){
        double liters2gallons = 0.264172;
        return liters * liters2gallons;
    }

    static void Main(string[] args){
        Console.WriteLine("Enter farhenheit to celcius");
        double farhenheit = double.Parse(Console.ReadLine());
        Console.WriteLine(FarhenheitToCelsius(farhenheit));

        Console.WriteLine("Enter celsius to farhenheit");
        double celsius = double.Parse(Console.ReadLine());
        Console.WriteLine(CelsiusToFarhenheit(celsius));

        Console.WriteLine("Enter pounds to kilograms");
        double pounds = double.Parse(Console.ReadLine());
        Console.WriteLine(PoundsToKilograms(pounds));

        Console.WriteLine("Enter kilograms to pounds");
        double kilograms = double.Parse(Console.ReadLine());
        Console.WriteLine(KilogramsToPounds(kilograms));

        Console.WriteLine("Enter gallons to liters");
        double gallons = double.Parse(Console.ReadLine());
        Console.WriteLine(GallonsToLiters(gallons));

        Console.WriteLine("Enter liters to gallons");
        double liters = double.Parse(Console.ReadLine());
        Console.WriteLine(LitersToGallons(liters));
    }
}
