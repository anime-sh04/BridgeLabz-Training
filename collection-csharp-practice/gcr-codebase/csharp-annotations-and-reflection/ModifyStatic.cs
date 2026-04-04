using System.Reflection;

class Configuration
{
    private static string API_KEY = "wbni3u2r3fuwj";
}

class Program
{
    static void Main()
    {

        Type type = typeof(Configuration);

        FieldInfo field = type.GetField("API_KEY", BindingFlags.NonPublic | BindingFlags.Static);

        if(field== null)
        {
            Console.Write("Not found");
            return;
        }
        
        // string value = (string)field.GetValue(null);
        // Console.WriteLine("API_KEY: " + value);
        Console.WriteLine($"API_KEY : {(string)field.GetValue(null)}");
        
        field.SetValue(null,"234512345qwer"); 
        Console.WriteLine($"NEW API_KEY : {(string)field.GetValue(null)}");
        
    }
}