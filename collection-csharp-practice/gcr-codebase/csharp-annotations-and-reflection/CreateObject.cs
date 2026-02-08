using System;
using System.Reflection;

class Student
{
    public int Id;
    public Student(int id)
    {
        Id = id;
    }
    public void Display()
    {
        Console.WriteLine($"Id: {Id}");
    }
}

class Program
{
    static void Main()
    {
        Type type = typeof(Student);

        #pragma warning disable
        object obj2 = Activator.CreateInstance(type,[101]);
        Student s2 = (Student)obj2;
        
        s2.Display();
    }
}
