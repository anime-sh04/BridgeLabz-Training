using System;
using System.Collections.Generic;
class Employee{
    public int Id;
    public string Name;

    public Employee(int id,string name){
        Id = id;
        Name =name;
    }
}

class Department{
    public string Name;
    private List<Employee> employees =new List<Employee>();

    public Department(string name){
        Name= name;
    }

    public void AddEmployee(int id, string name){
        employees.Add(new Employee(id,name));
    }

    public void RemoveAllEmployees(){
        employees.Clear();
    }

    public void ShowEmployees(){
        Console.WriteLine("Department: "+ Name);
        foreach(Employee e in employees){
            Console.WriteLine(e.Id +" "+ e.Name);
        }
    }
}

class Company{
    public string Name;
    private List<Department> departments = new List<Department>();

    public Company(string name){
        Name = name;
    }

    public void AddDepartment(string deptName){
        departments.Add(new Department(deptName));
    }

    public void AddEmployeeToDepartment(string deptName,int id, string empName){
        foreach(Department d in departments){
            if(d.Name ==deptName){
                d.AddEmployee(id,empName);
                return;
            }
        }
    }

    public void ShowCompany(){
        Console.WriteLine("Company: " + Name);
        foreach(Department d in departments){
            d.ShowEmployees();
        }
    }

    public void CloseCompany(){
        Console.WriteLine("Closing company and removing all departments and employees");
        foreach(Department d in departments){
            d.RemoveAllEmployees();
        }
        departments.Clear();
    }
}

class CompanyAndDepartments{
    static void Main(){
        Company c = new Company("BridgeLabz");

        c.AddDepartment("IT");
        c.AddDepartment("HR");
        c.AddEmployeeToDepartment("IT", 101, "Animesh");
        c.AddEmployeeToDepartment("IT", 102, "Afawg");
        c.AddEmployeeToDepartment("HR", 201, "Pajbe");

        c.ShowCompany();

        c.CloseCompany();

        c.ShowCompany();
    }
}
