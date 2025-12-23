using System;

class PrimeNumber{
	static void Main(string[] args){
		int number = Convert.ToInt32(Console.ReadLine());
		int count =0;
		for(int i=1;i<number/2;i++){
			if(number % i == 0){
				count++;
			}
		}
		if(count==1){
			Console.WriteLine("It is a Prime Number");
		}
		else{
			Console.WriteLine("It is not a Prime Number");
		}
	}
}