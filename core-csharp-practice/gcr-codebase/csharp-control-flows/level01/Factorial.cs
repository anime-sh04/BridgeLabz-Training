using System;

class Factorial{
	static void Main(string[] args){
		
		int number = Convert.ToInt32(Console.ReadLine());
		int fac = 1;
		if(number<0){
			Console.WriteLine("Enter a positive Number");
		}
		while(number!=0){
			fac = fac * number;
			number--;
		}
		Console.WriteLine("Factorial " + fac);
	}
}