using System.Collections.Generic;
using System.Text.RegularExpressions;

class FindRepeatingWords
{
    public static void Run()
    {
        string input = "This is is a repeated repeated word test.";
        string pattern = @"\b(\w+)\s+\1\b";
        var found = new HashSet<string>(System.StringComparer.OrdinalIgnoreCase);

        foreach (Match match in Regex.Matches(input, pattern, RegexOptions.IgnoreCase))
        {
            found.Add(match.Groups[1].Value);
        }

        foreach (string word in found)
        {
            System.Console.WriteLine(word);
        }
    }
}
