using Newtonsoft.Json;
using System.Xml;

class JsonToXml
{
    static void Main()
    {
        string json = @"{ 'user': { 'name':'Amit', 'age':28 } }";

        XmlDocument xml = JsonConvert.DeserializeXmlNode(json, "root");
        System.Console.WriteLine(xml.OuterXml);
    }
}
