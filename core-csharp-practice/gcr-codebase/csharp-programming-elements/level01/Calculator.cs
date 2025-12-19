using System;

class BasicCalculator
{
    static void Main(string[] args)
    {
        double firstNumber = Convert.ToDouble(Console.ReadLine());
        double secondNumber = Convert.ToDouble(Console.ReadLine());

        double addition = firstNumber + secondNumber;
        double subtraction = firstNumber - secondNumber;
        double multiplication = firstNumber * secondNumber;
        double division = firstNumber / secondNumber;

        Console.WriteLine("The addition, subtraction, multiplication and division value of 2 numbers "+ firstNumber + " and " + secondNumber + " is "+ addition + ", " + subtraction + ", " + multiplication + ", and " + division);
    }
}
