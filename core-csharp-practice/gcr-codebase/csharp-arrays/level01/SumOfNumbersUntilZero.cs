using System;

class SumOfNumbersUntilZero{
	static void Main(string[] args){
		
		double[] arr = new double[10];
		int i =0;
		while(true){
			double temp = double.Parse(Console.ReadLine());
			
			if(temp <=0){
				break;
			}
			if(i<9){
				arr[i] = temp;
				i++;
			}
			else{
				break;
			}
		}
		
		double sum=0;
		for(int j=0;j<arr.Length;j++){
			sum = sum + arr[j];
		}
		
		Console.WriteLine(sum);
	}
}

		
			