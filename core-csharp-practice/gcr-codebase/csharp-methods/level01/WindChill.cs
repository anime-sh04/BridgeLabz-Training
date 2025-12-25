using System;

class WindChill
{
    public static double Calculate(double temperature, double windSpeed){
        double windChill = 35.74+ 0.6215* temperature+ (0.4275 *temperature-35.75)* Math.Pow(windSpeed,0.16);

        return windChill;
    }

    static void Main(string[] args){
        double temperature = double.Parse(Console.ReadLine());
        double windSpeed = double.Parse(Console.ReadLine());

        double result = Calculate(temperature,windSpeed);

        Console.WriteLine(result);
    }
}
