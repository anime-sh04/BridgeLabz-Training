using System;

class chocolates{
	static void Main(string[] args){
		int numberOfChocolates = Convert.ToInt32(Console.ReadLine());
		int numberOfChildren = Convert.ToInt32(Console.ReadLine());
		
		int gets = numberOfChocolates/numberOfChildren;
		int remainingChocolates = numberOfChocolates%numberOfChildren;
		
		Console.WriteLine("The number of chocolates each child gets is "+gets+" and the number of remaining chocolates is "+ remainingChocolates);
	}
}

