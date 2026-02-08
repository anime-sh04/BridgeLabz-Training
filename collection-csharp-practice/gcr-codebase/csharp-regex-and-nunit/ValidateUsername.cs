using System.Text.RegularExpressions;

class ValidateUsername
{
    public static void Run()
    {
        string pattern = @"^[A-Za-z][A-Za-z0-9_]{4,14}$";
        string[] inputs = { "user_123", "123user", "us" };

        foreach (string input in inputs)
        {
            bool isValid = Regex.IsMatch(input, pattern);
            System.Console.WriteLine($"{input} -> {(isValid ? "Valid" : "Invalid")}");
        }
    }
}
