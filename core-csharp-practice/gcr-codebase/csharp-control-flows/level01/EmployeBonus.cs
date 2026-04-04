using System;

class EmployeBonus{
	static void Main(string[] args){
		
		double salary = Convert.ToDouble(Console.ReadLine());
		double yearOfService = Convert.ToDouble(Console.ReadLine());
		
		if(yearOfService > 5){
			double bonus = (salary * 5) / 100;
			salary = salary+bonus;
		}
		Console.WriteLine("Final Salary : " + salary);
	}
}