using System;
using System.Collections.Generic;

class WordFrequency
{
    static void Main()
    {
        string text = "Hello world, hello Java!";

        Dictionary<string, int> freq = new Dictionary<string, int>();

        string cleaned = "";
        foreach (char c in text.ToLower())
        {
            if (char.IsLetter(c) || c == ' ')
                cleaned += c;
        }

        string[] words = cleaned.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        foreach (string word in words)
        {
            if (freq.ContainsKey(word))
                freq[word]++;
            else
                freq[word] = 1;
        }

        foreach (var item in freq)
        {
            Console.WriteLine(item.Key + " : " + item.Value);
        }
    }
}
