using System.Reflection;

class Calculator
{
    private void Multiply(int a,int b)
    {
        Console.WriteLine(a*b);
    }
}

class InvokePrivateMethod
{
    static void Main()
    {
        Calculator calculator = new Calculator();
        Type type = typeof(Calculator);

        MethodInfo method = type.GetMethod("Multiply",BindingFlags.Instance | BindingFlags.NonPublic);

        method.Invoke(calculator,  [4, 5]);
    }
}