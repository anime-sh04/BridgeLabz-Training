using System;

class GCDAndLCM{
	public static int GCD(int a,int b){
		
		int min = a<b ? a: b;
		int high = 1;
		for(int i =1;i<= min;i++){
			if(a%i==0 && b%i==0){
				high =i;
			}
		}
		return high;
	}

	
	public static int LCM(int a,int b){
		int i=1;
		while(true){
			if(i%a == 0 && i%b == 0){
				return i;
			}
			i++;
		}
	}
	
	static void Main(string[] args){
		int a = int.Parse(Console.ReadLine());
		int b = int.Parse(Console.ReadLine());
		
		Console.WriteLine("GCD : " + GCD(a,b));
		Console.WriteLine("LCM : " + LCM(a,b));
	}
}
		