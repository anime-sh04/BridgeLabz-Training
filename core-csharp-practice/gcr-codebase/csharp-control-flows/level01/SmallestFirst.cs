using System;

class SmallestFirst{
	static void Main(string[] args){
		
		Console.WriteLine("Enter 1st Number :");
		int number1 = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter 2nd Number :");
		int number2 = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter 3rd Number :");
		int number3 = Convert.ToInt32(Console.ReadLine());
		
		if((number1 < number2) && (number1 < number3)){
			Console.WriteLine("Is the first number the smallest? True");
		}
		else{
			Console.WriteLine("Is the first number the smallest? False");
		}
	}
}
