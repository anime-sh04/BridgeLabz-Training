using System.Reflection;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
class BugReport : Attribute
{
    public string Description {get;}
    public BugReport(string description)
    {
        Description = description;
    }
}

class TaskManager
{
    [BugReport("Null Test")]
    [BugReport("Test2")]
    public void ProcessTask()
    {
        Console.WriteLine("Processing task..");
    }
}
class Program
{
    static void Main()
    {
        Type type = typeof(TaskManager);
        MethodInfo method = type.GetMethod("ProcessTask");

        object[] bugs = method.GetCustomAttributes(typeof(BugReport),false);
        foreach(BugReport bug in bugs)
        {
            Console.WriteLine("Bug : "+bug.Description);
        }
    }
}