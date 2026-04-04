using System;

class VolOfCylinder {
    public static void Main(String[] args) {
        double r = Convert.ToDouble(Console.ReadLine());
        double h = Convert.ToDouble(Console.ReadLine());

        double v = Math.PI * r*r*h;

        Console.WriteLine(v);
    }
}
    
