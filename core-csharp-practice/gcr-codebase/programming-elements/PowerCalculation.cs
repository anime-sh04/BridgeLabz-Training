using System;

class PowerCalculation {
    public static void Main(String[] args) {
        int baseN = Convert.ToInt32(Console.ReadLine());
        int power = Convert.ToInt32(Console.ReadLine());

        double result = Math.Pow(baseN, power);

        Console.WriteLine(result);
    }
}