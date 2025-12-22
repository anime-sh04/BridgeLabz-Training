using System;

class UntilZeroOrNegative{
	static void Main(string[] args){
		
		double number = Convert.ToDouble(Console.ReadLine());
		double sum =0;
		while(true){
			number = Convert.ToDouble(Console.ReadLine());
			sum = sum+number;
			if(number<=0.0){
				break;
			}
		}
		Console.WriteLine(sum);
	}
}