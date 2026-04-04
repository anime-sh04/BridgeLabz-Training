using System;

class EuclideanDistance{
	public static double Distance(double x1,double y1,double x2,double y2){
		double dx=x2-x1;
		double dy=y2-y1;
		double dist=Math.Sqrt(Math.Pow(dx,2)+Math.Pow(dy,2));
		return dist;
	}

	public static double[] LineEquation(double x1,double y1,double x2,double y2){
		double m=(y2-y1)/(x2-x1);
		double b=y1-m*x1;
		double[] result=new double[2];
		result[0]=m;
		result[1]=b;
		return result;
	}

	static void Main(string[] args){
		double x1 = double.Parse(Console.ReadLine());
		double y1 = double.Parse(Console.ReadLine());
		double x2 = double.Parse(Console.ReadLine());
		double y2 = double.Parse(Console.ReadLine());

		double d=Distance(x1,y1,x2,y2);
		Console.WriteLine("Distance = "+d);

		double[] line=LineEquation(x1,y1,x2,y2);
		Console.WriteLine("Equation: y = "+line[0]+"x + "+line[1]);
	}
}
