using System;

class MeanHeightOfPlayers{
	static void Main(string[] args){
		
		double[] arr = new double[11];
		double sum=0;
		double mean;
		for(int i=0;i<arr.Length;i++){
			arr[i] = double.Parse(Console.ReadLine());
		}
		
		for(int j=0;j<arr.Length;j++){
			sum = sum + arr[j];
		}
		
		mean = sum/11;
		
		Console.WriteLine(mean);
	}
}

		
			