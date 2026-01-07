using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    internal class EmployeeUtilityImpl : IEmployee
    {
        private List<Employee> employees = new List<Employee>();
        private Employee employee;
        private Random attendanceCheck = new Random(); 
        public Employee AddEmployee()
        {
            employee = new Employee();
            Console.Write("Enter ID: ");
            employee.EmployeeId = Console.ReadLine();

            Console.Write("Enter Name: ");
            employee.EmployeeName = Console.ReadLine();

            //Console.Write("Enter Salary: ");
            //employee.EmployeeSalary = double.Parse(Console.ReadLine());

            Console.Write("Enter Phone: ");
            employee.EmployeePhoneNumber = long.Parse(Console.ReadLine());

            employees.Add(employee);

            Console.WriteLine("Employee Added Successfully!");
            return employee;

        }

        public void AttendanceCheck()
        {
            int i = 1;
            foreach (Employee employee in employees)
            {
                Console.WriteLine($"Employee {i} attendance : ");
                long attendaceOtp = attendanceCheck.Next(1, 100000);
                i++;
                Console.WriteLine($"Enter The Number Displayed {attendaceOtp}");

                long employeeinput = long.Parse(Console.ReadLine());
                if (attendaceOtp == employeeinput)
                    employee.EmployeeAttendance = "Present";
                else
                    employee.EmployeeAttendance = "Abesent";
            }
        }
        

        public void DisplayEmployees()
        {
            foreach(Employee employee in employees)
            {
                Console.WriteLine(employee);
                Console.WriteLine("--");
            }   
        }
    }
}
