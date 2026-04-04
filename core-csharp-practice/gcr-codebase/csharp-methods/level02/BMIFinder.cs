using System;

class BMIFinderUsingMethods
{
    public static double[,] CalculateBMI(double[,] input){
		double[,] temp = new double[10,3];
        for (int i=0;i<10;i++){
            double weight = input[i,0];
            double heightCm = input[i,1];
            double heightMeter = heightCm/100;

            double bmi = weight/(heightMeter*heightMeter);

            temp[i,0] = weight;
            temp[i,1] = heightCm;
            temp[i,2] = bmi;
        }
        return temp;
    }

    public static string[] GetBMIStatus(double[,] data){
        string[] status = new string[10];

        for (int i=0;i<10;i++){
            double bmi = data[i,2];

            if (bmi <= 18.4)
                status[i] = "UnderWeight";
            else if (bmi <= 24.9)
                status[i] = "Normal";
            else if (bmi <= 39.9)
                status[i] = "OverWeight";
            else
                status[i] = "Obese";
        }

        return status;
    }

    static void Main(string[] args){
        int numberOfPersons = 10;

        double[,] input = new double[numberOfPersons,3];

        for (int i=0;i<numberOfPersons;i++){
            Console.WriteLine("For person "+(i+1));

            Console.WriteLine("Enter weight");
            input[i,0] = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter height");
            input[i,1] = double.Parse(Console.ReadLine());
        }

        double[,] persons = CalculateBMI(input);
        string[] status = GetBMIStatus(persons);

		Console.WriteLine("WeightStatus = ");
		for(int k =0;k<numberOfPersons;k++){
			Console.WriteLine("Person " + (k+1));
			for(int i =0;i<3;i++){
				Console.WriteLine(persons[k,i]);
			}
			Console.WriteLine(status[k]);
		}
    }
}
