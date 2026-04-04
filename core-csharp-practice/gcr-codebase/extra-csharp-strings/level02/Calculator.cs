using System;

class Calculator{
	
	public static double Add(double a,double b){
		return a+b;
	}
	public static double Sub(double a,double b){
		return a-b;
	}
	public static double Mul(double a,double b){
		return a*b;
	}
	public static double Div(double a,double b){
		return a/b;
	}
	static void Main(){
		Console.WriteLine("Enter Two NUmbers");
		double a =double.Parse(Console.ReadLine());
		double b = double.Parse(Console.ReadLine());
		
		Console.WriteLine("1. add \n 2.sub \n 3.mul \n 4. div");
		int ch= int.Parse(Console.ReadLine());
		switch(ch){
		case 1:
			Console.WriteLine(Add(a,b));
			break;
		case 2:
			Console.WriteLine(Sub(a,b));
			break;
		case 3:
			Console.WriteLine(Mul(a,b));
			break;
		case 4:
			Console.WriteLine(Div(a,b));
			break;
		default:
			Console.WriteLine("Invalid");
			break;
		}
	}
}
