using System;
using System.IO;
using System.Text.Json;

class ReadJson
{
    static void Main()
    {
        string json = File.ReadAllText("users.json");

        JsonDocument doc = JsonDocument.Parse(json);

        foreach (JsonProperty prop in doc.RootElement.EnumerateObject())
        {
            Console.WriteLine($"{prop.Name} : {prop.Value}");
        }
    }
}
