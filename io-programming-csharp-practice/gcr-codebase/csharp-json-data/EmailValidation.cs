using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

class EmailValidation
{
    static void Main()
    {
        string json = @"{ ""email"": ""test@gmail.com"" }";

        JSchema schema = JSchema.Parse(@"{
          'type':'object',
          'properties':{
            'email':{'type':'string','format':'email'}
          },
          'required':['email']
        }");

        JObject obj = JObject.Parse(json);
        bool valid = obj.IsValid(schema);

        System.Console.WriteLine(valid ? "Valid Email" : "Invalid Email");
    }
}
