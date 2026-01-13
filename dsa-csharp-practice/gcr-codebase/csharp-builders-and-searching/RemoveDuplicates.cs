using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        StringBuilder result = new StringBuilder();

        foreach (char ch in input)
        {
            if (!result.ToString().Contains(ch))
            {
                result.Append(ch);
            }
        }

        Console.WriteLine("After removing duplicates: " + result.ToString());
    }
}
