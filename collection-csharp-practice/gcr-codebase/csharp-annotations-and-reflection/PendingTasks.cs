using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
class TodoAttribute : Attribute
{
    public string Task { get; }
    public string AssignedTo { get; }
    public string Priority { get; }

    public TodoAttribute(string task, string assignedTo, string priority = "MEDIUM")
    {
        Task = task;
        AssignedTo = assignedTo;
        Priority = priority;
    }
}

class TaskManager
{
    [Todo("Add two value", "Animesh")]
    [Todo("Validate inputs", "Animesh")]
    public void AddTwoValue()
    {
        Console.WriteLine("Add two values");
    }

    [Todo("Add five value", "Animesh", "HIGH")]
    public void AddFiveValue()
    {
        Console.WriteLine("Add five values");
    }
}

class Program
{
    static void Main()
    {
        Type type = typeof(TaskManager);
        MethodInfo[] methods = type.GetMethods();

        foreach (MethodInfo method in methods)
        {
            object[] todos =
                method.GetCustomAttributes(typeof(TodoAttribute), false);

            foreach (TodoAttribute todo in todos)
            {
                Console.WriteLine(
                    $"Method: {method.Name}, Task: {todo.Task}, AssignedTo: {todo.AssignedTo}, Priority: {todo.Priority}");
            }
        }
    }
}
