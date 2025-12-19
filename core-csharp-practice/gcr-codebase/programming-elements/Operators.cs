using System;

class Operators{
	static void Main(string[] args){
		// Arithmetic Operators
		
		int a = 4;
		int b = 2;
		
		Console.WriteLine(a+b);
		Console.WriteLine(a-b);
		Console.WriteLine(a*b);
		Console.WriteLine(a/b);
		Console.WriteLine(a%b);
		
		// Relational Operators
		if(a==b){
			Console.WriteLine("A is equal to B");
		}
		if(a>=b){
			Console.WriteLine("A is greater than and equal to B");
		}
		if(a<=b){
			Console.WriteLine("A is less than and equal to B");
		}
		if(a!=b){
			Console.WriteLine("A is not equal to B");
		}
		if(a>b){
			Console.WriteLine("A is greater to B");
		}
		if(a<b){
			Console.WriteLine("A is less to B");
		}
		
		// Logical Operators
		
		bool i = true;
		bool j = false;
		
		Console.WriteLine(i && j); // False
		Console.WriteLine(i || j); // True
		Console.WriteLine(!i); // False
		
		// Unary Operators
		
		Console.WriteLine(a++); // a = a+1;
		Console.WriteLine(b--); // b = b-1;
		
		// Type Operators
		
		Console.WriteLine(a is int); // True
	}
}

		