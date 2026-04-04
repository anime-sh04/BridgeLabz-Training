using System;

class EmployeeBonus{
	static void Main(string[] args){
		double[] salary = new double[10];
		double[] years = new double[10];
		double[] newSalary = new double[10];
		double[] bonus = new double[10];
		
		double totalBonus =0, totalOldSalary=0, totalNewSalary=0;
		
		Console.Write("Enter 10 employees Salary");
		for(int i=0;i<10;i++){
			double temp = double.Parse(Console.ReadLine());
			if(temp < 0){
				Console.Write("Inavlid salary. Enter Again");
				i--;
			}
			else{
				salary[i] = temp;
				totalOldSalary = totalOldSalary + temp;
			}
		}
		Console.Write("Enter 10 employees years of salary");
		for(int i=0;i<10;i++){
			double temp = double.Parse(Console.ReadLine());
			if(temp < 0){
				Console.Write("Inavlid years. Enter Again");
				i--;
			}
			else{
				years[i] = temp;
			}
		}
		
		for(int i=0;i<10;i++){
			if(years[i] > 5){
				bonus[i] = (salary[i]*5)/ 100;
				newSalary[i] = salary[i] + bonus[i];
				totalBonus = totalBonus + bonus[i];
				totalNewSalary = totalNewSalary + newSalary[i];
			}
			else{
				bonus[i] = (salary[i]*2)/ 100;
				newSalary[i] = salary[i] + bonus[i];
				totalBonus = totalBonus + bonus[i];
				totalNewSalary = totalNewSalary + newSalary[i];
			}
		}
		
		Console.WriteLine("Total Bonus = " + totalBonus);
		Console.WriteLine("Total Old Salary = " + totalOldSalary);
		Console.WriteLine("Total New Salary = " + totalNewSalary);
	}
}

		