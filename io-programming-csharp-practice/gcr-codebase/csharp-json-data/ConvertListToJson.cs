using System.Text.Json;
using System.Collections.Generic;

class User
{
    public string name { get; set; }
    public int age { get; set; }
}

class ConvertListToJson
{
    static void Main()
    {
        List<User> users = new List<User>
        {
            new User { name = "Amit", age = 22 },
            new User { name = "Rohit", age = 30 }
        };

        string json = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });
        System.Console.WriteLine(json);
    }
}
