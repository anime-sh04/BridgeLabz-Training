using System;

class RandomValues{
	
	public static int[] Generate4DigitRandomArray(int size){
		int[] a = new int[size];
		Random rnd = new Random();

        for (int i=0;i<size;i++){
            a[i] = rnd.Next(1000,10000);
        }
		return a;
	}
	
	public static double[] FindAverageMinMax(int[] a)
    {
        double sum =0;
        int min =a[0];
        int max =a[0];

        for (int i=0;i<a.Length;i++){
            sum = sum + a[i];
            min = Math.Min(min,a[i]);
            max = Math.Max(max,a[i]);
        }

        double average = sum/a.Length;

        double[] result = new double[3];
        result[0] = average;
        result[1] = min;
        result[2] = max;

        return result;
    }	
	
	static void Main(string[] args){
		int[] arr = Generate4DigitRandomArray(5);
		double[] minMaxAvg = FindAverageMinMax(arr);
		
		for(int i=0;i<minMaxAvg.Length;i++){
			Console.WriteLine(minMaxAvg[i]);
		}
	}
}
