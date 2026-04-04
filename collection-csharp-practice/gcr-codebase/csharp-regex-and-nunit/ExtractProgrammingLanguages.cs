using System.Text.RegularExpressions;

class ExtractProgrammingLanguages
{
    public static void Run()
    {
        string text = "I love Java, Python, and JavaScript, but I haven't tried Go yet.";
        string pattern = @"\b(JavaScript|Java|Python|Go)\b";

        foreach (Match match in Regex.Matches(text, pattern))
        {
            System.Console.WriteLine(match.Value);
        }
    }
}
