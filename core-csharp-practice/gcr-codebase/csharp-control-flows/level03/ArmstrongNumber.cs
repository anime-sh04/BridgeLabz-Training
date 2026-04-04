using System;

class ArmStrongNumber{
	static void Main(string[] args){
		
		int number = Convert.ToInt32(Console.ReadLine());
		int original = number;
		
		int sum =0;
		while(number!=0){
			int d = number%10;
			sum = sum + (d*d*d);
			
			number = number/10;
		}
		if(original == sum){
			Console.WriteLine("It is a ArmStrongNumber");
		}
		else{
			Console.WriteLine("Its not an ArmStrongNumber");
		}
	}
}

			
			