using System.Text.RegularExpressions;

class ExtractEmails
{
    public static void Run()
    {
        string text = "Contact us at support@example.com and info@company.org";
        string pattern = @"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}";

        foreach (Match match in Regex.Matches(text, pattern))
        {
            System.Console.WriteLine(match.Value);
        }
    }
}
