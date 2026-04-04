using System;

class Employee{
    public int employeeID;
    protected string department;
    private double salary;

    public Employee(int employeeID, string department, double salary){
        this.employeeID = employeeID;
        this.department = department;
        this.salary = salary;
    }

    public void UpdateSalary(double newSalary){
        salary = newSalary;
    }

    public void AccessSalary(){
        Console.WriteLine("Salary : " + salary);
    }
}

class Manager :Employee{
    public Manager(int employeeID, string department, double salary)
        : base(employeeID, department, salary){
    }

    public void DisplayManagerDetails(){
        Console.WriteLine("Employee ID : " + employeeID);     // public
        Console.WriteLine("Department : " + department);     // protected
    }
}

class EmployeeRecords{
    static void Main(string[] args){
        Manager m1 = new Manager(1001, "IT",45000);

        m1.DisplayManagerDetails();

        m1.AccessSalary();
        m1.UpdateSalary(55000);
        m1.AccessSalary();
    }
}
