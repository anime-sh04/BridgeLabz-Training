using System;
using System.Text.Json;
using System.Collections.Generic;

class CsvToJson
{
    static void Main()
    {
        string[] lines = {
            "name,age",
            "Amit,22",
            "Rohit,30"
        };

        List<User> users = new List<User>();

        for (int i = 1; i < lines.Length; i++)
        {
            var data = lines[i].Split(',');
            users.Add(new User { name = data[0], age = int.Parse(data[1]) });
        }

        string json = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });
        Console.WriteLine(json);
    }
}
