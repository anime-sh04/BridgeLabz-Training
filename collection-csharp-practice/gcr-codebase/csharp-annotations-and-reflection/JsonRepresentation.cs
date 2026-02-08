using System;
using System.Reflection;
using System.Text;

class Student
{
    public int Id;
    private string Name;
    public int Age;

    public Student(int id, string name, int age)
    {
        Id = id;
        Name = name;
        Age = age;
    }
}

class JsonGenerator
{
    public static string ToJson(object obj)
    {
        Type type = obj.GetType();
        FieldInfo[] fields = type.GetFields(
            BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic
        );

        StringBuilder json = new StringBuilder();
        json.Append("{");

        for (int i = 0; i < fields.Length; i++)
        {
            FieldInfo field = fields[i];
            object value = field.GetValue(obj);

            json.Append($"\"{field.Name}\": \"{value}\"");

            if (i < fields.Length - 1)
                json.Append(", ");
        }

        json.Append("}");
        return json.ToString();
    }
}

class Program
{
    static void Main()
    {
        Student s = new Student(101, "Animesh", 21);

        string json = JsonGenerator.ToJson(s);
        Console.WriteLine(json);
    }
}
