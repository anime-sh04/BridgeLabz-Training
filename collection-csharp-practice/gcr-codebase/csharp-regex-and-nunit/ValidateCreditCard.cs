using System.Text.RegularExpressions;

class ValidateCreditCard
{
    public static void Run()
    {
        string visaPattern = @"^4\d{15}$";
        string masterCardPattern = @"^(5[1-5]\d{14}|2(2[2-9]\d{12}|[3-6]\d{13}|7(0\d{12}|1\d{12}|20\d{11})))$";

        string[] inputs = { "4111111111111111", "5500000000000004", "1234567890123456" };

        foreach (string input in inputs)
        {
            bool isVisa = Regex.IsMatch(input, visaPattern);
            bool isMasterCard = Regex.IsMatch(input, masterCardPattern);
            string type = isVisa ? "Visa" : isMasterCard ? "MasterCard" : "Invalid";
            System.Console.WriteLine($"{input} -> {type}");
        }
    }
}
