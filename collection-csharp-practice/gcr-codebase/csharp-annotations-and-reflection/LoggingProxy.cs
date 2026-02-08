using System;
using System.Reflection;

interface IGreeting
{
    void SayHello(string name);
}
class Greeting : IGreeting
{
    public void SayHello(string name)
    {
        Console.WriteLine("Hello, " + name);
    }
}

class LoggingProxy<T> : DispatchProxy
{
    private T _target;

    public static T Create(T target)
    {
        object proxy = Create<T, LoggingProxy<T>>();
        ((LoggingProxy<T>)proxy)._target = target;
        return (T)proxy;
    }

    protected override object Invoke(MethodInfo method, object[] args)
    {
        Console.WriteLine($"[LOG] Calling method: {method.Name}");
        return method.Invoke(_target, args);
    }
}

class Program
{
    static void Main()
    {
        IGreeting greeting = new Greeting();

        // Create proxy
        IGreeting proxy =
            LoggingProxy<IGreeting>.Create(greeting);

        // Call method via proxy
        proxy.SayHello("Animesh");
    }
}
