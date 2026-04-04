using System.Text.Json;
using System.Collections.Generic;

class Car
{
    public int Id { get; set; }
    public string Model { get; set; }
}

class ListToJson
{
    static void Main()
    {
        var cars = new List<Car>
        {
            new Car { Id = 1, Model = "BMW" },
            new Car { Id = 2, Model = "Audi" }
        };

        string json = JsonSerializer.Serialize(cars);
        System.Console.WriteLine(json);
    }
}
