using System;

class NaturalNumbers{
	static void Main(string[] args){
		int num = Convert.ToInt32(Console.ReadLine());
		
		if(num>0){
			int sumOfNaturalNumbers = num*(num+1)/2;
			Console.WriteLine("The sum of "+num+" natural numbers is "+ sumOfNaturalNumbers);
		}
		else{
			Console.WriteLine("The number "+num+ " is not a natural number");
		}
	}
}
