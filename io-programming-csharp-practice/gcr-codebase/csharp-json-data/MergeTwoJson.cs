using System;
using System.Text.Json;

class MergeTwoJson
{
    static void Main()
    {
        var obj1 = JsonSerializer.Deserialize<JsonElement>(
            @"{ ""name"": ""Animesh"" }"
        );
        var obj2 = JsonSerializer.Deserialize<JsonElement>(
            @"{ ""age"": 21 }"
        );

        var merged = new
        {
            name = obj1.GetProperty("name").GetString(),
            age = obj2.GetProperty("age").GetInt32()
        };

        Console.WriteLine(JsonSerializer.Serialize(merged));
    }
}
