using System;

class CollinearCheck{
	public static bool BySlope(double x1,double y1,double x2,double y2,double x3,double y3){
		double slopeAB = (y2-y1)/(x2-x1);
		double slopeBC = (y3-y2)/(x3-x2);
		double slopeAC = (y3-y1)/(x3-x1);
		
		if(slopeAB==slopeBC && slopeBC==slopeAC)
			return true;
		
		return false;
	}

	public static bool ByArea(double x1,double y1,double x2,double y2,double x3,double y3){
		double area = 0.5*(x1*(y2-y3)+x2*(y3-y1)+x3*(y1-y2));
		
		if(area == 0)
			return true;
		
		return false;
	}

	static void Main(string[] args){
		double x1=double.Parse(Console.ReadLine());
		double y1=double.Parse(Console.ReadLine());
		double x2=double.Parse(Console.ReadLine());
		double y2=double.Parse(Console.ReadLine());
		double x3=double.Parse(Console.ReadLine());
		double y3=double.Parse(Console.ReadLine());

		Console.WriteLine("By Slope: "+BySlope(x1,y1,x2,y2,x3,y3));
		Console.WriteLine("By Area: "+ByArea(x1,y1,x2,y2,x3,y3));
	}
}
