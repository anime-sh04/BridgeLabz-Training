using System;

class Employee{
    static string CompanyName = "BridgeLabz";

    private readonly int Id;
    private string Name;
    private string Designation;

    private static int TotalEmployees= 0;

    public Employee(int id, string name, string designation){
        this.Id = id;
        this.Name = name;
        this.Designation = designation;
        TotalEmployees++;
    }

    public void DisplayEmployeeDetails(){
        Console.WriteLine("Company Name : "+ CompanyName);
        Console.WriteLine("Employee ID : "+ Id);
        Console.WriteLine("Employee Name :"+ Name);
        Console.WriteLine("Designation : " + Designation);
    }

    public static void DisplayTotalEmployees(){
        Console.WriteLine("Total Employees in " +CompanyName+" are : "+ TotalEmployees);
    }
}

class EmployeeManagementSystem{
    static void Main(string[] args){
        Employee e1 = new Employee(101, "Animesh", "Software Developer");
        Employee e2 = new Employee(102, "ANeujs", "Datavae");

        if(e1 is Employee)
            Console.WriteLine("Yes its from Employee class");
        else
            Console.WriteLine("No its not from Employee class");

        e1.DisplayEmployeeDetails();
        e2.DisplayEmployeeDetails();
        Employee.DisplayTotalEmployees();
    }
}
