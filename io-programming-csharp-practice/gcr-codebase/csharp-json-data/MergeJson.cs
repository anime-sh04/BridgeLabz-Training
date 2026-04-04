using Newtonsoft.Json.Linq;

class MergeJson
{
    static void Main()
    {
        JObject json1 = JObject.Parse(@"{ 'name':'Amit' }");
        JObject json2 = JObject.Parse(@"{ 'age':28 }");

        json1.Merge(json2);

        System.Console.WriteLine(json1.ToString());
    }
}
