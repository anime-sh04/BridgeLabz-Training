using System;

class CountNumbers{
	static void Main(string[] args){
		
		int number = Convert.ToInt32(Console.ReadLine());
		int count =0;
		for(int i=number;i!=0;i=i/10){
			count++;
		}
		Console.WriteLine("Number of digits : " + count);
	}
}