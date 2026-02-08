using System.Reflection;

[AttributeUsage(AttributeTargets.Method)]
class TaskInfo : Attribute
{
    public int Priority {get;}
    public string AssignedTo {get;}
    public TaskInfo(int priority,string assignedTo)
    {
        Priority = priority;
        AssignedTo = assignedTo;
    }
}

class TaskManager
{
    [TaskInfo(1,"Animesh")]
    public void CompleteTask()
    {
        Console.WriteLine("Complete Task");
    }
}

class Program
{
    static void Main()
    {
        Type type = typeof(TaskManager);

        MethodInfo method =type.GetMethod("CompleteTask");
        TaskInfo att = (TaskInfo)Attribute.GetCustomAttribute(method,typeof(TaskInfo));
        if (att != null){
            Console.WriteLine("Priority: " + att.Priority);
            Console.WriteLine("Assigned To: " + att.AssignedTo);
        }
    }
}