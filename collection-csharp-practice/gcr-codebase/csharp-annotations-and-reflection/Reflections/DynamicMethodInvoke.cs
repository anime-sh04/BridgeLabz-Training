using System;
using System.Reflection;

class MathOperations
{
    public void Add(int a, int b)
    {
        Console.WriteLine("Result: "+ (a+b));
    }
    public void Subtract(int a, int b)
    {
        Console.WriteLine("Result: " +(a- b));
    }

    public void Multiply(int a, int b)
    {
        Console.WriteLine("Result: " + (a * b));
    }
}

class Program
{
    static void Main()
    {
        MathOperations math = new MathOperations();
        Type type = typeof(MathOperations);

        Console.Write("Enter method name (Add / Subtract / Multiply): ");
        string methodName = Console.ReadLine();

        Console.Write("Enter first number: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int b = int.Parse(Console.ReadLine());

        MethodInfo method = type.GetMethod(methodName);

        if (method == null)
        {
            Console.WriteLine("Method not found!");
            return;
        }

        method.Invoke(math, new object[] { a, b });
    }
}
