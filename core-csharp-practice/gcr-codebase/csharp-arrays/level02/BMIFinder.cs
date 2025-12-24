using System;

class BMIFinder{
	static void Main(string[] args){
		
		int numberOfPersons = int.Parse(Console.ReadLine());
		double[] weight = new double[numberOfPersons];
		double[] height = new double[numberOfPersons];
		double[] BMI = new double[numberOfPersons];
		string[] weightStatus = new string[numberOfPersons];
		
		Console.WriteLine("Enter weights of Persons");
		for(int j =0;j<weight.Length;j++){
			weight[j] = Convert.ToDouble(Console.ReadLine());
		}
		Console.WriteLine("Enter heights of Persons");
		
		for(int j =0;j<height.Length;j++){
			
			height[j] = double.Parse(Console.ReadLine());
		}
		
		for(int j =0;j<BMI.Length;j++){
			double temp = weight[j]/((height[j]/100) * (height[j]/100));
			BMI[j] = temp;
		}
		
		for(int j =0;j<weightStatus.Length;j++){
			if(BMI[j] <= 18.4){
				weightStatus[j] = "UnderWeight";
			}
			else if(BMI[j] >= 18.5 && BMI[j] <= 24.9){
				weightStatus[j]="Normal";
			}
			else if(BMI[j] >= 25.0 && BMI[j] <= 39.9){
				weightStatus[j] = "OverWeight";
			}
			else{
				weightStatus[j] = "Obese";
			}
		}
		Console.WriteLine("weightStatus = ");
		for(int k =0;k<weightStatus.Length;k++){
			Console.WriteLine(weightStatus[k]);
		}
	}
}
