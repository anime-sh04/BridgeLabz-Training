using System;

class FootBallTeam{
	public static int FindSum(int[] a){
		int sum =0;
		for(int i=0;i<11;i++){
			sum = sum+a[i];
		}
		return sum;
	}
	public static double FindMean(int a){
		double mean = a/11;
		return mean;
	}
	public static int FindShortest(int[] a){
		int shortest = a[0];
		for(int i=0;i<11;i++){
			if(a[i] < a[0])
				shortest = a[i];
		}
		return shortest;
	}
	
	public static int FindTallest(int[] a){
		int tallest = a[0];
		for(int i=0;i<11;i++){
			if(a[i] > a[0])
				tallest = a[i];
		}
		return tallest;
	}
	
	
	static void Main(string[] args){
		int[] heights = new int[11];
		
		Random rnd = new Random();
		for(int i=0;i<11;i++){
			heights[i] = rnd.Next(150,251);
		}
		
		int sum = FindSum(heights);
		double mean = FindMean(sum);
		int shortest = FindShortest(heights);
		int tallest = FindTallest(heights);
		Console.WriteLine(sum);
		Console.WriteLine(mean);
		Console.WriteLine(shortest);
		Console.WriteLine(tallest);
	}
}