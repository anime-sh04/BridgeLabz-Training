using System;

class QuotientAndRemainder
{
    static void Main(string[] args)
    {
        int number1 = Convert.ToInt32(Console.ReadLine());
        int number2 = Convert.ToInt32(Console.ReadLine());

        int quotient = number1/number2;
        int remainder = number1%number2;

        Console.WriteLine("The Quotient is "+ quotient+ " and Remainder is " + remainder + " of two numbers " + number1 + " and " +number2);
    }
}
