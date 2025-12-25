using System;

class NumberChecker{
	public static bool isPositive(int n){
		if(n >= 0){
			return true;
		}
		else{
			return false;
		}
	}
	public static bool isEven(int n){
		if(n%2 == 0){
			return true;
		}
		else{
			return false;
		}
	}
	public static int compare(int n, int n2){
		if(n>n2){
			return 1;
		}
		else if(n2>n){
			return -1;
		}
		else{
			return 0;
		}
	}
	
	static void Main(string[] args){
		int[] numbers = new int[5];
		for(int i=0;i<5;i++){
			numbers[i] = int.Parse(Console.ReadLine());
		}
		for(int i=0;i<5;i++){
			if(isPositive(numbers[i]))
				Console.WriteLine("Positive");
			else
				Console.WriteLine("Negative");
			
			if(isEven(numbers[i]))
				Console.WriteLine("Even");
			else
				Console.WriteLine("Odd");
		}
		Console.WriteLine(compare(numbers[0] , numbers[4]));
	}
}