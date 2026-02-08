using System.Diagnostics;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method)]
class LogExecutionTimeAttribute : Attribute
{
}


class TaskManager
{
    [LogExecutionTime]
    public void FastTask()
    {
        Thread.Sleep(500);
    }
    [LogExecutionTime]
    public void SlowTask()
    {
        Thread.Sleep(1500);
    }
}

class Program
{
    static void Main()
    {
        TaskManager manager = new TaskManager();
        Type type = typeof(TaskManager);
        MethodInfo[] methods = type.GetMethods();

        foreach(MethodInfo method in methods)
        {
            if (Attribute.IsDefined(method, typeof(LogExecutionTimeAttribute)))
            {
                Stopwatch s = new Stopwatch();
                s.Start();
                method.Invoke(manager,null);
                s.Stop();
                Console.WriteLine($"Method: {method.Name},Execution Time: {s.ElapsedMilliseconds} ms");
            }
        }
    }
}