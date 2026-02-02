using System;
using System.IO;
using System.Text.Json;

class ReadAJson
{
    static void Main()
    {
        string json = File.ReadAllText("sample.json");

        using JsonDocument doc = JsonDocument.Parse(json);
        JsonElement root = doc.RootElement;

        string name = root.GetProperty("name").GetString();
        string email = root.GetProperty("email").GetString();

        Console.WriteLine("Name: " + name);
        Console.WriteLine("Email: " + email);
    }
}
