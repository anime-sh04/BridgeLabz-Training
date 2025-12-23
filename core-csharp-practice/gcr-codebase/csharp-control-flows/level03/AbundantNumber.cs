using System;

class AbundantNumber{
	static void Main(string[] args){
		
		int number = Convert.ToInt32(Console.ReadLine());
		
		int sumOfDivisor =0;
		
		for(int i= 1;i<=number/2;i++){
			if(number%i == 0){
				sumOfDivisor = sumOfDivisor + i;
			}
		}
		if(sumOfDivisor>number){
			Console.WriteLine("Its an Abundant Number");
		}
		else{
			Console.WriteLine("Its not an Abundant Number");
		}
	}
}
