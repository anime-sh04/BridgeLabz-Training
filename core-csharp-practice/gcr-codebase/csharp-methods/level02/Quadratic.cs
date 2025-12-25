using System;

class Quadratic{
	public static double[] quad(int a,int b,int c){
		double[] temp = new double[2];
		double delta = Math.Pow(b,2) -4*a*c;
		double sqrtDelta = Math.Sqrt(delta);
		if(delta>0){
			temp[0] = (-b+sqrtDelta)/(2*a);
			temp[1] = (-b-sqrtDelta)/(2*a);
		}
		else if(delta==0){
			temp[0] = -b/(2*a);
		}
		else{
			return temp;
		}
		return temp;
	}
			
	static void Main(string[] args){
		int a = int.Parse(Console.ReadLine());
		int b = int.Parse(Console.ReadLine());
		int c = int.Parse(Console.ReadLine());
		
		double[] arr = quad(a,b,c);
		
		for(int i=0;i<2;i++){
			Console.WriteLine(arr[i]);
		}
	}
}
