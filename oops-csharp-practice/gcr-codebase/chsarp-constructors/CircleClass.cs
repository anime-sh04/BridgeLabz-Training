using System;

class Circle{
	private double Radius;
	
	// Default Constructor 
	public Circle(): this(0){
	}
	// Parameterized Constructor 
	public Circle(double radius){
		this.Radius = radius;
	}
	
	public void Display(){
		Console.WriteLine("Radius : " + Radius);
	}
}

class CircleClass{
	static void Main(string[] args){
		Circle b = new Circle();
		Circle b1 = new Circle(123.35);
		b.Display();
		b1.Display();
	}
}