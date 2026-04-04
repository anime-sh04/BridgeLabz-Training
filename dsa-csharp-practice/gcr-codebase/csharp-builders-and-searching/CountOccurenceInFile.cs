using System;
using System.IO;

class CountOccurenceInFile
{
    static void Main(string[] args)
    {
        string path = "Example.txt";

        Console.Write("Enter the word to search: ");
        string word = Console.ReadLine();

        int count = 0;

        StreamReader reader = new StreamReader(path);
        string line;

        while ((line = reader.ReadLine()) != null)
        {
            string[] words = line.Split(' ');

            foreach (string w in words)
            {
                if (w.Equals(word, StringComparison.OrdinalIgnoreCase))
                {
                    count++;
                }
            }
        }

        reader.Close();

        Console.WriteLine($"The word '{word}' appears {count} times.");
    }
}
