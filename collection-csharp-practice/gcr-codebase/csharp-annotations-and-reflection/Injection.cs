using System;
using System.Reflection;


[AttributeUsage(AttributeTargets.Field)]
class InjectAttribute : Attribute
{
}

class Logger
{
    public void Log(string message)
    {
        Console.WriteLine("[LOG] " + message);
    }
}

class Service
{
    [Inject]
    private Logger logger;

    public void Execute()
    {
        logger.Log("Service executed");
    }
}

class DIContainer
{
    public static T Resolve<T>() where T : new()
    {
        T obj = new T();
        InjectDependencies(obj);
        return obj;
    }

    private static void InjectDependencies(object obj)
    {
        Type type = obj.GetType();

        FieldInfo[] fields = type.GetFields(
            BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public
        );

        foreach (FieldInfo field in fields)
        {
            if (Attribute.IsDefined(field, typeof(InjectAttribute)))
            {
                object dependency =
                    Activator.CreateInstance(field.FieldType);

                field.SetValue(obj, dependency);
            }
        }
    }
}
class Program
{
    static void Main()
    {
        Service service = DIContainer.Resolve<Service>();
        service.Execute();
    }
}
