using System;

class FactorialUsingForLoop{
	static void Main(string[] args){
		
		int number = Convert.ToInt32(Console.ReadLine());
		int fac = 1;
		if(number<0){
			Console.WriteLine("Enter a positive Number");
		}
		else{
			for(int i = number; i!=0;i--){
				fac = fac * i;
			}
			Console.WriteLine("Factorial Using ForLoop : " + fac);
		}
	}
}