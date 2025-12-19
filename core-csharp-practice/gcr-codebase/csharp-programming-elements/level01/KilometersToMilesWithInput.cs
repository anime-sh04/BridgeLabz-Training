using System;

class KilometersToMilesWithInput{
	static void Main(string[] args){
		int kiloMeter = Convert.ToInt32(Console.ReadLine());
		double miles = (double)kiloMeter/1.6;
		
		Console.WriteLine("The total miles is " + miles + " mile for the given "+ kiloMeter);
	}
}