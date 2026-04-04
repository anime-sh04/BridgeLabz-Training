using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

// Employee class
class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public double Salary { get; set; }
}

// Main program class
class SerializationDemo
{
    static void Main()
    {
        string filePath = "employees.json";

        // Create list of employees
        List<Employee> employees = new List<Employee>()
        {
            new Employee { Id = 1, Name = "Animesh", Department = "IT", Salary = 50000 },
            new Employee { Id = 2, Name = "Afifa", Department = "HR", Salary = 45000 }
        };

        try
        {
            // Serialize (Save to file)
            string jsonData = JsonSerializer.Serialize(employees);
            File.WriteAllText(filePath, jsonData);
            Console.WriteLine("Employees saved successfully.");

            // Deserialize (Read from file)
            string readData = File.ReadAllText(filePath);
            List<Employee> empList =
                JsonSerializer.Deserialize<List<Employee>>(readData);

            // Display data
            Console.WriteLine("\nEmployee Details:");
            foreach (Employee emp in empList)
            {
                Console.WriteLine(
                    "ID: " + emp.Id +
                    ", Name: " + emp.Name +
                    ", Department: " + emp.Department +
                    ", Salary: " + emp.Salary);
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("I/O Error: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
