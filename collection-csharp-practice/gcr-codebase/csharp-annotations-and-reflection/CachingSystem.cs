using System;
using System.Collections.Generic;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method)]
class CacheResultAttribute : Attribute
{
}

class Calculator
{
    [CacheResult]
    public int SlowSquare(int x)
    {
        Console.WriteLine("Computing result...");
        Thread.Sleep(1000);
        return x * x;
    }
}

class CacheInvoker
{
    private static Dictionary<string, object> cache = new Dictionary<string, object>();
    public static object Invoke(object target, MethodInfo method, object[] parameters)
    {
        string key = method.Name + "_" + string.Join("_", parameters);

        if (Attribute.IsDefined(method, typeof(CacheResultAttribute)))
        {
            if (cache.ContainsKey(key))
            {
                Console.WriteLine("Returning cached result");
                return cache[key];
            }

            object result = method.Invoke(target, parameters);
            cache[key] = result;
            return result;
        }

        return method.Invoke(target, parameters);
    }
}

class Program
{
    static void Main()
    {
        Calculator calc = new Calculator();
        MethodInfo method = typeof(Calculator).GetMethod("SlowSquare");

        Console.WriteLine(CacheInvoker.Invoke(calc, method, [5]));
        Console.WriteLine(CacheInvoker.Invoke(calc, method, [5]));
        Console.WriteLine(CacheInvoker.Invoke(calc, method, [6]));
        Console.WriteLine(CacheInvoker.Invoke(calc, method, [5]));
    }
}
