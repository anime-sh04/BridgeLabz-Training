using System;

class TrigonometryFunctions
{
    public static double[] Calculate(double angle)
    {
        double radians = angle* Math.PI/180;

        double sine = Math.Sin(radians);
        double cosine = Math.Cos(radians);
        double tangent = Math.Tan(radians);

        double[] result = new double[3];
        result[0] = sine;
        result[1] = cosine;
        result[2] = tangent;

        return result;
    }

    static void Main(string[] args)
    {
        double angle = double.Parse(Console.ReadLine());

        double[] values = Calculate(angle);

        Console.WriteLine("Sine: " + values[0]);
        Console.WriteLine("Cosine: " + values[1]);
        Console.WriteLine("Tangent: " + values[2]);
    }
}
