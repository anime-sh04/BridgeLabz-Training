using System.Reflection;

[AttributeUsage(AttributeTargets.Method)]
class ImportantMethodAttribute : Attribute
{
    public string Importance{get;}
    public ImportantMethodAttribute(string importance = "HIGH")
    {
        Importance = importance;
    }
}

class Task
{
    [ImportantMethod]
    public void highTest()
    {
        Console.WriteLine("High importance");
    }
    
    [ImportantMethod("LOW")]
    public void lowTest()
    {
        Console.WriteLine("Low importance");
    }
}

class Program
{
    static void Main()
    {
        Type type = typeof(Task);
        MethodInfo[] methods = type.GetMethods();

        foreach(MethodInfo method in methods)
        {
            ImportantMethodAttribute attr = (ImportantMethodAttribute)Attribute.GetCustomAttribute(method,typeof(ImportantMethodAttribute));
            if (attr != null)
            {
                Console.WriteLine($"METHOD: {method.Name}, Importact: {attr.Importance}");
            }
        }


    }
}