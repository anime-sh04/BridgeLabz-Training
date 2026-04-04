using System;

class BMIFinder{
	static void Main(string[] args){
		double weight = Convert.ToDouble(Console.ReadLine());
		double height = Convert.ToDouble(Console.ReadLine());
		double heightInmeter = height/100;
		double bmi = weight/(heightInmeter*weight);
		
		if(bmi <= 18.4){
			Console.WriteLine("UnderWeight");
		}
		else if(bmi >= 18.5 && bmi <= 24.9){
			Console.WriteLine("Normal");
		}
		else if(bmi >= 25.0 && bmi <= 39.9){
			Console.WriteLine("OverWeight");
		}
		else{
			Console.WriteLine("Obese");
		}
	}
}

		