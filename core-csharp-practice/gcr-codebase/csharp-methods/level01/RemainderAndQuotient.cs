using System;

class RemainderAndQuotient{
	public static int[] FindRemainderAndQuotient(int number, int divisor){
		int remainder = divisor%number;
		int quotient = divisor/number;
		
		int[] arr = new int[2];
		arr[0] = remainder;
		arr[1] = quotient;
		
		return arr;
	}
	static void Main(string[] args){
		int number = int.Parse(Console.ReadLine());
		int divisor = int.Parse(Console.ReadLine());
		
		int[] a = FindRemainderAndQuotient(number,divisor);
		
		Console.WriteLine("Remainder : "+a[0]);
        Console.WriteLine("Quotient : "+a[1]);
	}
}