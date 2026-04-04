using System.Text.RegularExpressions;

class ReplaceMultipleSpaces
{
    public static void Run()
    {
        string input = "This  is   an example   with multiple   spaces.";
        string result = Regex.Replace(input, @"\s+", " ").Trim();
        System.Console.WriteLine(result);
    }
}
