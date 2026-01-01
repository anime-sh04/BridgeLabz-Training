using System;

class AreaOfCircle{
	private double radius;
	
	public AreaOfCircle(double r){
		this.radius = r;
	}
	public void Display(){
		double areaFormula = Math.PI*radius*radius;
		double CircumferenceFormula = 2*Math.PI*radius;
		
		Console.WriteLine("Area Of Circle : " + areaFormula);
		Console.WriteLine("Circumference Of the circle : " + CircumferenceFormula);
	}
}

class Area{
	static void Main(string[] args){
		AreaOfCircle area = new AreaOfCircle(12.4);
		area.Display();
	}
}