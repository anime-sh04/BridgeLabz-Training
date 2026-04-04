using System;

class PerimeterOfRectangle {
    public static void Main(String[] args) {
        int l = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(2*(l+b));
    }
}