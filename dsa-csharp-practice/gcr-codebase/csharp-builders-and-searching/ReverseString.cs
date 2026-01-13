using System;
using System.Text;

class ReverseString
{
    static void Main(string[] args)
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        StringBuilder sb = new StringBuilder(input);

        StringBuilder reversed = new StringBuilder();
        for (int i = sb.Length - 1; i >= 0; i--)
        {
            reversed.Append(sb[i]);
        }

        Console.WriteLine("Reversed String: " + reversed.ToString());
    }
}
