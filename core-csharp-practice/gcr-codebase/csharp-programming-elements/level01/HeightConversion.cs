using System;

class HeightConversion{
	static void Main(string[] args){
		double height = Convert.ToDouble(Console.ReadLine());
		double inches = height/2.54;
		double foot = inches/12;
		
		Console.WriteLine("Your Height in cm is "+height + " while in feet is "+ foot+" and inches is " + inches);
	}
}