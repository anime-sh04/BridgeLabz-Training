using System;
using System.Collections.Generic;
using System.Reflection;

class ObjectMapper
{
    public static T ToObject<T>(Type clazz, Dictionary<string, object> properties)
    {
        object obj = Activator.CreateInstance(clazz);

        foreach (var item in properties)
        {
            FieldInfo field = clazz.GetField(
                item.Key,
                BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic
            );

            if (field != null)
            {
                field.SetValue(obj, item.Value);
            }
        }

        return (T)obj;
    }
}

class Student
{
    public int Id;
    private string Name;

    public void Display()
    {
        Console.WriteLine($"Id: {Id}, Name: {Name}");
    }
}

class Program
{
    static void Main()
    {
        Dictionary<string, object> data = new Dictionary<string, object>()
        {
            { "Id", 101 },
            { "Name", "Animesh" }
        };

        Student student = ObjectMapper.ToObject<Student>(
            typeof(Student), data);

        student.Display();
    }
}
