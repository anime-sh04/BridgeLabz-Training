using System;

class NumberChecker4{
	public static bool IsPrime(int n){
		if(n<=1)
			return false;
		for(int i=2;i<=n/2;i++){
			if(n%i==0)
				return false;
		}
		return true;
	}

	public static bool IsNeon(int n){
		int sq =n*n;
		int sum =0;
		while(sq!=0){
			sum=sum+(sq%10);
			sq=sq/10;
		}
		return sum==n;
	}

	public static bool IsSpy(int n){
		int sum =0,prod =1;
		while(n!=0){
			int d =n%10;
			sum = sum+d;
			prod = prod*d;
			n =n/10;
		}
		return sum==prod;
	}

	public static bool IsAutomorphic(int n){
		int sq = n*n;
		int temp =n;
		while(temp!=0){
			if((sq%10) != (temp%10))
				return false;
			sq=sq/10;
			temp=temp/10;
		}
		return true;
	}

	public static bool IsBuzz(int n){
		if(n%7==0 || n%10==7)
			return true;
		return false;
	}

	static void Main(string[] args){
		int number=int.Parse(Console.ReadLine());

		Console.WriteLine(IsPrime(number));
		Console.WriteLine(IsNeon(number));
		Console.WriteLine(IsSpy(number));
		Console.WriteLine(IsAutomorphic(number));
		Console.WriteLine(IsBuzz(number));
	}
}
