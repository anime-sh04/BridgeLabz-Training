using System.Text.Json;
using System.Collections.Generic;

class Report
{
    public string product { get; set; }
    public int quantity { get; set; }
}

class JsonReport
{
    static void Main()
    {
        List<Report> records = new List<Report>
        {
            new Report { product = "Laptop", quantity = 5 },
            new Report { product = "Mouse", quantity = 20 }
        };

        string jsonReport = JsonSerializer.Serialize(records, new JsonSerializerOptions { WriteIndented = true });
        System.Console.WriteLine(jsonReport);
    }
}
