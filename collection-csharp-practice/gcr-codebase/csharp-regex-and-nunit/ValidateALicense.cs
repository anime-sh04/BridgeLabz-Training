using System.Text.RegularExpressions;

class ValidateALicense
{
    public static void Run()
    {
        string pattern = @"^[A-Z]{2}[0-9]{4}$";
        string licensePlate = "AB1234";
        if (Regex.IsMatch(licensePlate, pattern))
        {
            System.Console.WriteLine("Valid license plate.");
        }
        else
        {
            System.Console.WriteLine("Invalid license plate.");
        }
    }
}
