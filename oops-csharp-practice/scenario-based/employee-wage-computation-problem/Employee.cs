using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    internal class Employee
    {
        private string employeeid {  get; set; }
        private string employeename { get; set; }
        private double employeedailywage { get; set; }
        private long employeephonenumber { get; set; }

        private string employeeattendance {  get; set; } // UC1 Employee Attendance Check

        public string EmployeeId
        {
            get { return employeeid; }
            set { employeeid = value; }
        }
        public string EmployeeName
        {
            get { return employeename; }
            set { employeename = value; }
        }
        public double EmployeeDailyWage
        {
            get { return employeedailywage;  }
            set { employeedailywage = value; }
        }
        public long EmployeePhoneNumber
        {
            get { return employeephonenumber; }
            set { employeephonenumber = value; }
        }

        public string EmployeeAttendance
        {
            get { return employeeattendance; }
            set { employeeattendance = value; }
        }


        public override string? ToString()
        {
            return "Employee ID : "+employeeid + "\nEmployee Name : " + employeename + "\nEmployee Salary/Wage : " + employeedailywage + "\nEmployee Phone Number : " + employeephonenumber + "\nEmployee Attendance : " + employeeattendance;
        }
    }
}
