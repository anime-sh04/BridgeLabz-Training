using System;
using System.Collections.Generic;

namespace EmployeeSystem
{
    interface IDepartment
    {
        void AssignDepartment(string dept);
        string GetDepartmentDetails();
    }

    abstract class Employee : IDepartment
    {
        private int employeeId;
        private string name;
        private double baseSalary;
        private string department;

        public int EmployeeId
        {
            get { return employeeId; }
            set { employeeId = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double BaseSalary
        {
            get { return baseSalary; }
            set { baseSalary = value; }
        }

        public Employee(int id, string name, double baseSalary)
        {
            EmployeeId = id;
            Name = name;
            BaseSalary = baseSalary;
        }
        public abstract double CalculateSalary();
        public void DisplayDetails()
        {
            Console.WriteLine("Employee ID : " + EmployeeId);
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("Department : " + GetDepartmentDetails());
            Console.WriteLine("Final Salary : " + CalculateSalary());
        }

        public void AssignDepartment(string dept)
        {
            department = dept;
        }

        public string GetDepartmentDetails()
        {
            return department;
        }
    }

    class FullTimeEmployee : Employee
    {
        public FullTimeEmployee(int id, string name, double salary)
            : base(id, name, salary)
        {
        }

        public override double CalculateSalary()
        {
            return BaseSalary;
        }
    }

    class PartTimeEmployee : Employee
    {
        private int workHours;
        private double ratePerHour;

        public PartTimeEmployee(int id, string name, int hours, double rate)
            : base(id, name,0)
        {
            workHours = hours;
            ratePerHour = rate;
        }

        public override double CalculateSalary()
        {
            return workHours * ratePerHour;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            Employee e1 = new FullTimeEmployee(101, "Animesh",50000);
            e1.AssignDepartment("IT");

            Employee e2 = new PartTimeEmployee(102,"Rahul", 80, 300);
            e2.AssignDepartment("Support");

            employees.Add(e1);
            employees.Add(e2);

            foreach (Employee emp in employees)
            {
                emp.DisplayDetails();
            }

            Console.ReadLine();
        }
    }
}
