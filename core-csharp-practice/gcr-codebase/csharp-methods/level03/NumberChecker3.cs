using System;

class NumberChecker{
	public static int Count(int n){
		int c=0;
		while(n!=0){
			c++;
			n=n/10;
		}
		return c;
	}

	public static int[] Digits(int n,int c){
		int[] a=new int[c];
		int idx=0;
		for(int i=n;i!=0;i=i/10){
			int d=i%10;
			a[idx]=d;
			idx++;
		}
		return a;
	}

	public static int[] Reverse(int[] a){
		int[] r=new int[a.Length];
		int j=0;
		for(int i=a.Length-1;i>=0;i--){
			r[j]=a[i];
			j++;
		}
		return r;
	}

	public static bool Compare(int[] a,int[] b){
		if(a.Length!=b.Length)
			return false;
		for(int i=0;i<a.Length;i++){
			if(a[i]!=b[i])
				return false;
		}
		return true;
	}

	public static bool IsPalindrome(int[] digits){
		int[] reversed=Reverse(digits);
		return Compare(digits,reversed);
	}

	public static bool IsDuck(int[] a){
		for(int i=0;i<a.Length;i++){
			if(a[i]!=0)
				return true;
		}
		return false;
	}

	static void Main(string[] args){
		int number=int.Parse(Console.ReadLine());
		int count=Count(number);
		int[] digits=Digits(number,count);

		for(int i=0;i<digits.Length;i++){
			Console.Write(digits[i]+" ");
		}
		Console.WriteLine();

		int[] reversed=Reverse(digits);

		for(int i=0;i<reversed.Length;i++){
			Console.Write(reversed[i]+" ");
		}
		Console.WriteLine();

		Console.WriteLine(Compare(digits,reversed));
		Console.WriteLine(IsPalindrome(digits));
		Console.WriteLine(IsDuck(digits));
	}
}
