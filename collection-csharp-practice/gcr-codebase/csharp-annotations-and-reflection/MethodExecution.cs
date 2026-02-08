using System;
using System.Diagnostics;
using System.Reflection;
using System.Threading;

class TaskRunner
{
    public void FastTask()
    {
        Thread.Sleep(300);
    }

    public void SlowTask()
    {
        Thread.Sleep(800);
    }
}

class MethodTimer
{
    public static void MeasureExecutionTime(object obj)
    {
        Type type = obj.GetType();

        MethodInfo[] methods = type.GetMethods(
            BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly
        );

        foreach (MethodInfo method in methods)
        {
            if (method.GetParameters().Length == 0)
            {
                Stopwatch sw = new Stopwatch();

                sw.Start();
                method.Invoke(obj, null);
                sw.Stop();

                Console.WriteLine(
                    $"Method: {method.Name}, Time: {sw.ElapsedMilliseconds} ms"
                );
            }
        }
    }
}

class Program
{
    static void Main()
    {
        TaskRunner runner = new TaskRunner();
        MethodTimer.MeasureExecutionTime(runner);
    }
}
