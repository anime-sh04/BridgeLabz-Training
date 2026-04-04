using System.Text.RegularExpressions;

class ExtractCurrencyValues
{
    public static void Run()
    {
        string text = "The price is $45.99, and the discount is $ 10.50.";
        string pattern = @"\$\s?\d+(\.\d{2})?";

        foreach (Match match in Regex.Matches(text, pattern))
        {
            string value = match.Value;
            if (value.StartsWith("$ "))
            {
                value = value.Substring(2);
            }
            else
            {
                value = value.Replace("$ ", "$");
            }

            System.Console.WriteLine(value);
        }
    }
}
