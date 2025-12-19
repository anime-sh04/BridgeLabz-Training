using System;

class SwapTwoNumbers
{
    static void Main(string[] args)
    {
        int number1 = Convert.ToInt32(Console.ReadLine());
        int number2 = Convert.ToInt32(Console.ReadLine());
		int temp = number1;
		number1 = number2;
		number2 = temp;
		
        Console.WriteLine("The swapped numbers are "+number1+" and "+ number2);
    }
}
