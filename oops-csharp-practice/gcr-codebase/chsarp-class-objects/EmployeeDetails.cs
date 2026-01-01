using System;

class EmployeeDetails{
	private string name;
	private string id;
	private double salary;
	
	public EmployeeDetails(string name, string id,double salary){
		this.name = name;
		this.id = id;
		this.salary = salary;
	}
	
	public void DisplayDetails(){
		Console.WriteLine("Employee Name : " + name);
		Console.WriteLine("Employee ID : " + id);
		Console.WriteLine("Employee Salary : " + salary);
	}
}

class Employee{
	static void Main(string[] args){
		EmployeeDetails employee = new EmployeeDetails("Animesh", "GLA24786",18202.24);
		
		employee.DisplayDetails();
	}
}
