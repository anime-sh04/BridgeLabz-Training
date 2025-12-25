using System;

class SumOfNaturalNumbers{
	
	public static int Sum(int n, int s){
		if(n==0){
			return s;
		}
		return Sum(n-1, s+n);
	}
	
	static void Main(string[] args){
		int number = int.Parse(Console.ReadLine());
		
		int sumUsingFormula = number*(number+1)/2;
		int sumUsingRecursion = Sum(number,0);
		
		Console.WriteLine("sumUsingFormula : " + sumUsingFormula);
		Console.WriteLine("sumUsingRecursion : " + sumUsingRecursion);
	}
}
