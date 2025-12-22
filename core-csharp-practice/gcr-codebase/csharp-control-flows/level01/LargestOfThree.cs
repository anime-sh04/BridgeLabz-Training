using System;

class LargestOfThree{
	static void Main(string[] args){
		
		Console.WriteLine("Enter 1st Number :");
		int number1 = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter 2nd Number :");
		int number2 = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter 3rd Number :");
		int number3 = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Is the first number the largest? "+ ((number1 > number2) && (number1 > number3)));
		Console.WriteLine("Is the second number the largest? " + ((number2 > number1) && (number2 > number3)));
		Console.WriteLine("Is the third number the largest? " + ((number3 > number1) && (number3 > number2)));
	}
}