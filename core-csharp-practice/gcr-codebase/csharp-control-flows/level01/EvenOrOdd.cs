using System;

class EvenOrOdd{
	static void Main(string[] args){
		
		int number = Convert.ToInt32(Console.ReadLine());
		if(number<0){
			Console.WriteLine("Enter a positive Number");
		}
		else{
			for(int i=1;i<=number;i++){
				if(i %2 == 0){
					Console.WriteLine(i +" is even");
				}
				else{
					Console.WriteLine(i +" is odd");
				}
			}
		}
	}
}