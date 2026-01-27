using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string[] usernames = {"user_123","123user","us" };

        foreach (string username in usernames)
        {
            if (IsValidUsername(username))
                Console.WriteLine($"{username} → Valid");
            else
                Console.WriteLine($"{username} → Invalid");
        }
    }

    static bool IsValidUsername(string username)
    {
        string pattern = @"^[A-Za-z][A-Za-z0-9_]{4,14}$";
        return Regex.IsMatch(username, pattern);
    }
}
