using System;

class NumberChecker5{
	public static int[] Factors(int n){
		int count=0;
		for(int i=1;i<=n;i++){
			if(n%i==0)
				count++;
		}
		int[] a=new int[count];
		int idx=0;
		for(int i=1;i<=n;i++){
			if(n%i==0){
				a[idx]=i;
				idx++;
			}
		}
		return a;
	}

	public static int GreatestFactor(int[] a){
		int max=a[0];
		for(int i=1;i<a.Length;i++){
			if(a[i]>max)
				max=a[i];
		}
		return max;
	}

	public static int SumOfFactors(int[] a){
		int sum=0;
		for(int i=0;i<a.Length;i++){
			sum=sum+a[i];
		}
		return sum;
	}

	public static long ProductOfFactors(int[] a){
		long p=1;
		for(int i=0;i<a.Length;i++){
			p=p*a[i];
		}
		return p;
	}

	public static double ProductOfCubeOfFactors(int[] a){
		double p=1;
		for(int i=0;i<a.Length;i++){
			p = p*Math.Pow(a[i],3);
		}
		return p;
	}

	public static bool IsPerfect(int n,int[] a){
		int sum=0;
		for(int i=0;i<a.Length-1;i++){
			sum = sum+a[i];
		}
		return sum==n;
	}

	public static bool IsAbundant(int n,int[] a){
		int sum=0;
		for(int i=0;i<a.Length-1;i++){
			sum = sum+a[i];
		}
		return sum > n;
	}

	public static bool IsDeficient(int n,int[] a){
		int sum=0;
		for(int i=0;i<a.Length-1;i++){
			sum = sum+a[i];
		}
		return sum<n;
	}

	public static int Factorial(int d){
		int f=1;
		for(int i=1;i<=d;i++){
			f = f*i;
		}
		return f;
	}

	public static bool IsStrong(int n){
		int temp=n;
		int sum=0;
		while(temp!=0){
			int d = temp%10;
			sum = sum+Factorial(d);
			temp = temp/10;
		}
		return sum == n;
	}

	static void Main(string[] args){
		int number=int.Parse(Console.ReadLine());

		int[] f=Factors(number);

		for(int i=0;i<f.Length;i++){
			Console.Write(f[i]+" ");
		}
		Console.WriteLine();

		Console.WriteLine(GreatestFactor(f));
		Console.WriteLine(SumOfFactors(f));
		Console.WriteLine(ProductOfFactors(f));
		Console.WriteLine(ProductOfCubeOfFactors(f));
		Console.WriteLine(IsPerfect(number,f));
		Console.WriteLine(IsAbundant(number,f));
		Console.WriteLine(IsDeficient(number,f));
		Console.WriteLine(IsStrong(number));
	}
}
