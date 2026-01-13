using Microsoft.VisualBasic;
using System;
using System.Text;

class ConcatenateString
{
    static void Main(string[] args)
    {
        string[] words = { "Hello", " ", "World", " ", "from", " ", "C#" };

        StringBuilder sb = new StringBuilder();

        foreach (string word in words)
        {
            sb.Append(word);
        }

        Console.WriteLine("Concatenated String: " + sb.ToString());
    }
}
