using System;

class EmployeesBonus{
	static Random r=new Random();

	public static double[,] GenerateEmployeeData(int n){
		double[,] data = new double[n,2];
		for(int i=0;i<n;i++){
			data[i,0] = r.Next(10000,100000);
			data[i,1] = r.Next(1,11);
		}
		return data;
	}

	public static double[,] CalculateBonusAndNewSalary(double[,] oldData){
		int n=oldData.GetLength(0);
		double[,] newData=new double[n,2];

		for(int i=0;i<n;i++){
			double salary=oldData[i,0];
			double years=oldData[i,1];
			double bonus;

			if(years>5)
				bonus = salary*0.05;
			else
				bonus= salary*0.02;

			newData[i,0]= salary +bonus;
			newData[i,1]= bonus;
		}
		return newData;
	}

	public static void CalculateTotals(double[,] oldData,double[,] newData){
		double oldSum=0,newSum=0,bonusSum=0;

		for(int i=0;i<oldData.GetLength(0);i++){
			oldSum =oldSum + oldData[i,0];
			newSum =newSum +newData[i,0];
			bonusSum+=bonusSum+ newData[i,1];
		}

		Console.WriteLine("Total Old Salary: "+oldSum);
		Console.WriteLine("Total New Salary: "+newSum);
		Console.WriteLine("Total Bonus: "+bonusSum);
	}

	static void Main(string[] args){
		int employees=10;

		double[,] oldData=GenerateEmployeeData(employees);
		double[,] newData=CalculateBonusAndNewSalary(oldData);

		Console.WriteLine("Emp OldSalary Years Bonus NewSalary");

		for(int i=0;i<employees;i++){
			Console.WriteLine((i+1)+" "+oldData[i,0]+" "+oldData[i,1]+" "+newData[i,1]+" "+newData[i,0]);
		}

		CalculateTotals(oldData,newData);
	}
}
