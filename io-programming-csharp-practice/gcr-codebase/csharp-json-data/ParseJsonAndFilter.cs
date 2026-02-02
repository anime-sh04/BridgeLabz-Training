using System.Text.Json;
using System.Collections.Generic;
using System.Linq;

class Person
{
    public string name { get; set; }
    public int age { get; set; }
}


string json = @"[
  { ""name"": ""Amit"", ""age"": 22 },
  { ""name"": ""Rohit"", ""age"": 28 },
  { ""name"": ""Neha"", ""age"": 30 }
]";

List<Person> people = JsonSerializer.Deserialize<List<Person>>(json);

var result = people.Where(p => p.age > 25).ToList();
