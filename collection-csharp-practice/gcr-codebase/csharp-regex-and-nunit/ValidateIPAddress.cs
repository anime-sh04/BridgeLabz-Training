using System.Text.RegularExpressions;

class ValidateIPAddress
{
    public static void Run()
    {
        string pattern = @"^((25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)\.){3}(25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)$";
        string[] inputs = { "192.168.1.1", "255.255.255.255", "256.1.1.1" };

        foreach (string input in inputs)
        {
            bool isValid = Regex.IsMatch(input, pattern);
            System.Console.WriteLine($"{input} -> {(isValid ? "Valid" : "Invalid")}");
        }
    }
}
