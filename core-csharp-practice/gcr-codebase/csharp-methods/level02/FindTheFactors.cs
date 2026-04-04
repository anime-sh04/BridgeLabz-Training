using System;
class FindTheFactors{
	public static int[] Factors(int number){
		
		int count = 0;
		for(int i=1;i<=number;i++){
			if(number%i==0){
				count++;
			}
		}
		int[] a = new int[count];
		int idx = 0;
		for(int i=1;i<=number;i++){
			if(number%i==0){
				a[idx] = i;
				idx++;
			}
		}
		
		return a;
	}
	public static int FactorsSum(int[] a){
		int sum =0;
		for(int i=0;i<a.Length;i++){
			sum = sum + a[i];
		}
		return sum;
	}
	
	public static int FactorsProduct(int[] a){
		int product =0;
		for(int i=0;i<a.Length;i++){
			product = product + a[i];
		}
		return product;
	}
	public static double FindSumOfSquares(int[] a){
        double sum = 0;
        for (int i=0;i<a.Length; i++){
            sum = sum + Math.Pow(a[i], 2);
        }
        return sum;
    }
	
	static void Main(string[] args){
		int number = int.Parse(Console.ReadLine());
		
		int[] factors = Factors(number);
		int sum = FactorsSum(factors);
		int product = FactorsProduct(factors);
		double square = FindSumOfSquares(factors);
		
		Console.Write("Factors : ");
		for(int i =0;i<factors.Length;i++){
			Console.WriteLine(factors[i] + " ");
		}
		Console.WriteLine("Sum : " + sum);
		Console.WriteLine("Product : " + product);
		Console.WriteLine("Square : " + square);
	}
}