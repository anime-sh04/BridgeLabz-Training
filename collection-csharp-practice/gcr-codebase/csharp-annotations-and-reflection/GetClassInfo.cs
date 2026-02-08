using System;
using System.Reflection;

class Sample
{
    
    #pragma warning disable
    public int id;
    private string name;
    public Sample() { }

    public Sample(int id)
    {
        this.id = id;
    }

    public void Show()
    {
        Console.WriteLine("Show method");
    }

    private void Hidden()
    {
    }
}

class GetClassInfo
{
    static void Main()
    {
        Console.Write("Enter class name: ");
        string className = Console.ReadLine();
        Type type = Type.GetType(className);

        if (type == null)
        {
            Console.WriteLine("Class not found!");
            return;
        }

        Console.WriteLine("\nFields");
        foreach (FieldInfo field in type.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic))
        {
            Console.WriteLine(field.Name);
        }

        Console.WriteLine("\nMethods");
        foreach (MethodInfo method in type.GetMethods(
            BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.DeclaredOnly))
        {
            Console.WriteLine(method.Name);
        }

        Console.WriteLine("\nConstructors");
        foreach (ConstructorInfo c in type.GetConstructors(
            BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic))
        {
            Console.WriteLine(c.ToString());
        }
    }
}
