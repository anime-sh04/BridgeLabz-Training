using System.Text.RegularExpressions;

class ExtractLinks
{
    public static void Run()
    {
        string text = "Visit https://www.google.com and http://example.org for more info.";
        string pattern = @"\bhttps?://[^\s]+";

        foreach (Match match in Regex.Matches(text, pattern))
        {
            System.Console.WriteLine(match.Value);
        }
    }
}
