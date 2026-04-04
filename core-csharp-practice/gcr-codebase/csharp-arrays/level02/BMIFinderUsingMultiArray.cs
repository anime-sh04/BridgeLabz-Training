using System;

class BMIFinderUsingMultiArray{
	static void Main(string[] args){
		
		int numberOfPersons = int.Parse(Console.ReadLine());
		double[,] personData = new double[numberOfPersons,3];
		string[] weightStatus = new string[numberOfPersons];
		double weight,height;
		for(int i =0;i<numberOfPersons;i++){
			
			Console.WriteLine("For person "+(i+1));
			while(true){
				Console.WriteLine("Enter Weight for " + (i+1) +"person");
				weight = double.Parse(Console.ReadLine());
				if(weight<0){
					Console.WriteLine("Enter weight in +ve");
				}
				else{
					personData[i,0] = weight;
					break;
				}
			}
			while(true){
				Console.WriteLine("Enter Height for " + (i+1) +"person");
				height = double.Parse(Console.ReadLine());
				if(weight<0){
					Console.WriteLine("Enter height in +ve");
				}
				else{
					personData[i,1] = height;
					break;
				}
			}
			double BMI = weight/((height/100) * (height/100));
			personData[i,2] = BMI;
		}
		
		for(int j =0;j<numberOfPersons;j++){
			if(personData[j,2] <= 18.4){
				weightStatus[j] = "UnderWeight";
			}
			else if(personData[j,2] >= 18.5 && personData[j,2] <= 24.9){
				weightStatus[j]="Normal";
			}
			else if(personData[j,2] >= 25.0 && personData[j,2] <= 39.9){
				weightStatus[j] = "OverWeight";
			}
			else{
				weightStatus[j] = "Obese";
			}
		}
		Console.WriteLine("WeightStatus = ");
		for(int k =0;k<numberOfPersons;k++){
			Console.WriteLine("Person " + (k+1));
			for(int i =0;i<3;i++){
				Console.WriteLine(personData[k,i]);
			}
			Console.WriteLine(weightStatus[k]);
		}
	}
}
