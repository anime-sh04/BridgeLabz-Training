using System.Text.RegularExpressions;

class ValidateSSN
{
    public static void Run()
    {
        string pattern = @"^\d{3}-\d{2}-\d{4}$";
        string[] inputs = { "123-45-6789", "123456789" };

        foreach (string input in inputs)
        {
            bool isValid = Regex.IsMatch(input, pattern);
            System.Console.WriteLine($"{input} -> {(isValid ? "Valid" : "Invalid")}");
        }
    }
}
