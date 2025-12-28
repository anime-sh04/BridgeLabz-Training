using System;

class TemperatureConverter{
    public static double FahrenheitToCelsius(double f){
        return (f-32)* 5/9;
    }

    public static double CelsiusToFahrenheit(double c){
        return (c *9 /5)+32;
    }

    static void Main(string[] args){
        Console.WriteLine("1. For F to C");
        Console.WriteLine("2. C to F");
        int choice = int.Parse(Console.ReadLine());

        if (choice == 1){
            Console.Write("Enter temperature in F: ");
            double f = double.Parse(Console.ReadLine());
            double c = FahrenheitToCelsius(f);
            Console.WriteLine("Temperature in C : " + c);
        }
        else if (choice == 2){
            Console.Write("Enter temperature in C : ");
            double c = double.Parse(Console.ReadLine());
            double f = CelsiusToFahrenheit(c);
            Console.WriteLine("Temperature in F: " + f);
        }
        else{
            Console.WriteLine("Invalid choice");
        }
    }
}
