using System.Text.RegularExpressions;

class ExtractCapitalizedWords
{
    public static void Run()
    {
        string text = "The Eiffel Tower is in Paris and the Statue of Liberty is in New York.";
        string pattern = @"\b[A-Z][a-z]+\b";

        foreach (Match match in Regex.Matches(text, pattern))
        {
            System.Console.WriteLine(match.Value);
        }
    }
}
