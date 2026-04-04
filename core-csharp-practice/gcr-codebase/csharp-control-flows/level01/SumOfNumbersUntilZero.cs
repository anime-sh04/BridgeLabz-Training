using System;

class SumOfNumbersUntilZero{
	static void Main(string[] args){
		
		double number = Convert.ToDouble(Console.ReadLine());
		double sum =0;
		while(number!=0.0){
			number = Convert.ToDouble(Console.ReadLine());
			sum = sum+number;
		}
		Console.WriteLine(sum);
	}
}