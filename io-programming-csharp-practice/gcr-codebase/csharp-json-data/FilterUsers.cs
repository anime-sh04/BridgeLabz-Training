using System.Text.Json;
using System.Collections.Generic;
using System.Linq;

class FilterUsers
{
    static void Main()
    {
        string json = @"[
          { ""name"": ""Amit"", ""age"": 22 },
          { ""name"": ""Rohit"", ""age"": 30 }
        ]";

        List<User> users = JsonSerializer.Deserialize<List<User>>(json);

        var filtered = users.Where(u => u.age > 25);

        foreach (var u in filtered)
        {
            System.Console.WriteLine(u.name);
        }
    }
}
