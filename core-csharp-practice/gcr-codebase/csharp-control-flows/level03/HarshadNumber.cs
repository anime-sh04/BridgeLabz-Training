using System;

class HarshadNumber{
	static void Main(string[] args){
		
		int number = Convert.ToInt32(Console.ReadLine());
		int sum = 0;
		for(int i=number;i!=0;i=i/10){
			int d = i%10;
			sum = sum+d;
		}
		if(number%sum == 0){
			Console.WriteLine("Its a Harshad Number");
		}
		else{
			Console.WriteLine("Its not a Harshad Number");
		}
	}
}
