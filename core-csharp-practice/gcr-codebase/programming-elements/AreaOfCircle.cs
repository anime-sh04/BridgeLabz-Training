using System;

class AreaOfCircle {
    public static void Main(String[] args) {

        double r = Convert.ToDouble(Console.ReadLine());
        double area = Math.PI * r * r;

        Console.WriteLine("Area = " + area);
    }
}
