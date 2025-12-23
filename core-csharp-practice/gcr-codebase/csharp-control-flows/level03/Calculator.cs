using System;

class Calculator
{
    static void Main(string[] args){
		double first = Convert.ToDouble(Console.ReadLine());
		double second = Convert.ToDouble(Console.ReadLine());
		
		string op = Console.ReadLine();
		
		switch (op){
			case "+":
				Console.WriteLine(first+second);
				break;
			case "-":
				Console.WriteLine(first-second);
				break;
			case "*":
				Console.WriteLine(first*second);
				break;
			case "/":
				Console.WriteLine(first/second);
				break;
			default:
				Console.WriteLine("Invalid Operator");
				break;
		}
    }
}
