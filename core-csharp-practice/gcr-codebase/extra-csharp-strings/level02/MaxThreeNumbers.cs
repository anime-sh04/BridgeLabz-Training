using System;

class MaxThreeNumbers{
	public static int Input(){
		int a = int.Parse(Console.ReadLine());
		int b = int.Parse(Console.ReadLine());
		int c = int.Parse(Console.ReadLine());
		
		return Maximum(a,b,c);
	}
	public static int Maximum(int a ,int b, int c){
		if(a>b && a>c)
			return a;
		else if(b>a && b>c)
			return b;
		else
			return c;
	}
	
	static void Main(string[] args){
		int a = Input();
		Console.WriteLine("Maximum Number is : " + a);
	}
}