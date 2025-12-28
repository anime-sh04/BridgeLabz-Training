using System;

class PrimeNumber{
	public static bool prime(int n){
		int c =0;
		for(int i =1;i<n/2;i++){
			if(n%i == 0)
				c++;
		}
		if(c==1)
			return true;
		else
			return false;
	}
	
	static void Main(string[] args){
		int n = int.Parse(Console.ReadLine());
		Console.WriteLine(prime(n)? "Its a prime" : "Not a prime");
	}
}