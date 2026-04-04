using System;

class SumOfNaturalNumbersUsingFor{
	static void Main(string[] args){
		
		int number = Convert.ToInt32(Console.ReadLine());
		int sumUsingFor =0;
		int sumUsingFormula = number * (number+1)/2;
		for(int i = number; i!=0; i--){
			sumUsingFor = sumUsingFor+i;
		}
		
		Console.WriteLine("Sum using Formula : " + sumUsingFormula);
		Console.WriteLine("Sum using ForLoop : " + sumUsingFor);
	}
}