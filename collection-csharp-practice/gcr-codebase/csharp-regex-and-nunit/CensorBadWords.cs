using System.Text.RegularExpressions;

class CensorBadWords
{
    public static void Run()
    {
        string input = "This is a damn bad example with some stupid words.";
        string pattern = @"\b(damn|stupid)\b";
        string result = Regex.Replace(input, pattern, "****", RegexOptions.IgnoreCase);
        System.Console.WriteLine(result);
    }
}
