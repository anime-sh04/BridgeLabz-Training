using System;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

class ValidateJson
{
    static void Main()
    {
        string jsonData = @"{
            'name': 'Animesh',
            'email': 'animesh@gmail.com',
            'age': 21
        }";

        string jsonSchema = @"{
            'type': 'object',
            'properties': {
                'name': { 'type': 'string' },
                'email': { 'type': 'string' },
                'age': { 'type': 'integer' }
            },
            'required': [ 'name', 'email' ]
        }";

        JSchema schema = JSchema.Parse(jsonSchema);
        JObject jsonObject = JObject.Parse(jsonData);

        bool isValid = jsonObject.IsValid(schema, out IList<string> errors);

        if (isValid)
        {
            Console.WriteLine("JSON is valid ✅");
        }
        else
        {
            Console.WriteLine("JSON is invalid ❌");
            foreach (var error in errors)
            {
                Console.WriteLine(error);
            }
        }
    }
}
