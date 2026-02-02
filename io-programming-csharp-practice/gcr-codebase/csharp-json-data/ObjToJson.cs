// // using Newtonsoft.Json;
// using System;
// using System.Text.Json;
// class Car
// {
//     public string Brand { get; set; }
//     public string Model { get; set; }
//     public int Year { get; set; }
// }

// class ObjToJson
// {
//     static void Main()
//     {
//         Car car = new Car
//         {
//             Brand = "Toyota",
//             Model = "Fortuner",
//             Year = 2022
//         };

//         string json = JsonSerializer.Serialize(car,new JsonSerializerOptions{WriteIndented=true});

//         Console.WriteLine(json);
//     }
// }
