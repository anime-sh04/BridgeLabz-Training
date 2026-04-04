using System;

class SumOfNaturalNumbers{
	static void Main(string[] args){
		
		int number = Convert.ToInt32(Console.ReadLine());
		int sumUsingWhile =0;
		int sumUsingFormula = number * (number+1)/2;
		while(number!=0){
			sumUsingWhile = sumUsingWhile+number;
			number--;
		}
		Console.WriteLine("Sum using Formula : " + sumUsingFormula);
		Console.WriteLine("Sum using WhileLoop : " + sumUsingWhile);
	}
}