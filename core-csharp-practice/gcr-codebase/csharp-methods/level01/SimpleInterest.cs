using System;

class SimpleInterest{
	public static double CalculateSI(double principle , double rate , double time){
		double SI = (principle*rate*time)/100;
			
		return SI;
		}
	static void Main(string[] args){
		
		double principle = double.Parse(Console.ReadLine());
		double rate = double.Parse(Console.ReadLine());
		double time = double.Parse(Console.ReadLine());
		
		double S = CalculateSI(principle,rate,time);
		Console.WriteLine(S);
	}
}