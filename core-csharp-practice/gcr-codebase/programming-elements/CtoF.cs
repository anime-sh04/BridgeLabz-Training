using System;

class CtoF {
    public static void Main(String[] args) {
        double c = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Fahrenheit = " + ((c * 9 / 5) + 32));
    }
}
