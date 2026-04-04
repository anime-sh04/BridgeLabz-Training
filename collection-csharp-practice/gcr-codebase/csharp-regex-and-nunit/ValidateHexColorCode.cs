using System.Text.RegularExpressions;

class ValidateHexColorCode
{
    public static void Run()
    {
        string pattern = @"^#[0-9A-Fa-f]{6}$";
        string[] inputs = { "#FFA500", "#ff4500", "#123" };

        foreach (string input in inputs)
        {
            bool isValid = Regex.IsMatch(input, pattern);
            System.Console.WriteLine($"{input} -> {(isValid ? "Valid" : "Invalid")}");
        }
    }
}
