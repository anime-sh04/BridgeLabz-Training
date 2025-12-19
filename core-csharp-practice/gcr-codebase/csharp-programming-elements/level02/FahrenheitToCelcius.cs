using System;

class TemperatureConversion{
	static void Main(string[] args){
		double fahrenheit = Convert.ToDouble(Console.ReadLine());
		double celcius = (fahrenheit-32)*5/9;
		
		Console.WriteLine("The "+fahrenheit+" Fahrenheit is "+celcius+" Celcius");
	}
}