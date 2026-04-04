using System;
using System.Reflection;
using System.Text;

[AttributeUsage(AttributeTargets.Field)]
class JsonFieldAttribute : Attribute
{
    public string Name { get; set; }
}

class User
{
    [JsonField(Name = "user_name")]
    public string Username;

    [JsonField(Name = "user_age")]
    public int Age;

    public User(string username, int age)
    {
        Username = username;
        Age = age;
    }
}

class JsonSerializer
{
    public static string ToJson(object obj)
    {
        Type type = obj.GetType();
        FieldInfo[] fields = type.GetFields();

        StringBuilder json = new StringBuilder();
        json.Append("{");

        bool first = true;

        foreach (FieldInfo field in fields)
        {
            JsonFieldAttribute attr =
                (JsonFieldAttribute)Attribute.GetCustomAttribute(
                    field, typeof(JsonFieldAttribute));

            if (attr != null)
            {
                if (!first)
                    json.Append(", ");

                string key = attr.Name;
                object value = field.GetValue(obj);

                json.Append($"\"{key}\": \"{value}\"");
                first = false;
            }
        }

        json.Append("}");
        return json.ToString();
    }
}

class Program
{
    static void Main()
    {
        User user = new User("Animesh", 21);

        string json = JsonSerializer.ToJson(user);
        Console.WriteLine(json);
    }
}
