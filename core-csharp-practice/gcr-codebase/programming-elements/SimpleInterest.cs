using System;

class SimpleInterest {
    public static void Main(String[] args) {
        double p = Convert.ToDouble(Console.ReadLine());
        double r = Convert.ToDouble(Console.ReadLine());
        double t = Convert.ToDouble(Console.ReadLine());

        double si = (p*r*t)/100;
        Console.WriteLine(si);
    }
}
