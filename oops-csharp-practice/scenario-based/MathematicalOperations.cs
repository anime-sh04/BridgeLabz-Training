/*2. Scenario: You are tasked with creating a utility class for mathematical operations.
Implement the following functionalities using separate methods:
● A method to calculate the factorial of a number.
● A method to check if a number is prime.
● A method to find the greatest common divisor (GCD) of two numbers.
● A method to find the nth Fibonacci number.
● Test your methods with various inputs, including edge cases like zero, one, and
negative numbers.*/
using System;

class MathematicalUtility{
	public void Factorial(){
		Console.WriteLine("Enter a number : ");
		int n = int.Parse(Console.ReadLine());
		int sum = 1;
		while(n>1){
			sum = sum*n;
			n--;
		}
		Console.WriteLine("Factorial : "+sum);
	}
	
	public void Prime(){
		Console.WriteLine("Enter a number : ");
		int n = int.Parse(Console.ReadLine());
		int c = 0;
		int i =1;
		while(i<=n/2){
			if(n%i==0)
				c++;
			i++;
		}
		if(c==1)
			Console.WriteLine("Its a prime");
		else
			Console.WriteLine("Its not a prime");
	}
	
	public void Fibonacci(){
		Console.WriteLine("Enter a number : ");
		int n = int.Parse(Console.ReadLine());
		int a =0,b=1,c=0;
		Console.Write("Fibonacci : " );
		for(int i =0;i<n;i++){
			Console.Write(a+ " ");
			c = a+b;
			a = b;
			b = c;
		}
	}
	public void GCD(){
		Console.WriteLine("Enter two numbers to find GCD : ");
		int n = int.Parse(Console.ReadLine());
		int n2 = int.Parse(Console.ReadLine());
		int highest = 0;
		for(int i =1;i<n;i++){
			if(n%i ==0 && n2%i ==0){
				if(i>highest){
					highest =i;
				}
			}
		}
		Console.WriteLine("GCD : " + highest);
	}
}
	
	
	
class MathematicalOperations{
	static void Main(string[] arrgs){
		MathematicalOperations obj = new MathematicalOperations();
		obj.Menu();
	}
	void Menu(){
		MathematicalUtility utility = new MathematicalUtility();
		while(true){
			
			Console.WriteLine("==Mathematical Operations==");
			Console.WriteLine("1. Factorial");
			Console.WriteLine("2. Prime Number");
			Console.WriteLine("3. Fibonacci");
			Console.WriteLine("4. Greatest Common Divisor");
			Console.WriteLine("5. Exit");
			int n = int.Parse(Console.ReadLine());
			switch(n){
				case 1:
					utility.Factorial();break;
				case 2:
					utility.Prime();break;
				case 3:
					utility.Fibonacci();break;
				case 4:
					utility.GCD();break;
				case 5:
					return;
				default:
					Console.WriteLine("Invalid Choice");
					break;
			}
		}
	}
}
			
		
		