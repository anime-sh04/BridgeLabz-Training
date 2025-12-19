using System;

class AreaOfTriangle{
	static void Main(string[] args){
		double height = Convert.ToDouble(Console.ReadLine());
		double basenum = Convert.ToDouble(Console.ReadLine());
		
		double Area = 0.5 * height * basenum;
		
		Console.WriteLine("Area of Triangle is " + Area);
	}
}
