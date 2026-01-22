using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

class WordCountExample
{
    static void Main()
    {
        string filePath = "input.txt";
        Dictionary<string, int> wordCount = new Dictionary<string, int>();

        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    // Split line into words
                    string[] words = line.Split(
                        new char[] { ' ', ',', '.', ';', ':', '!', '?' },
                        StringSplitOptions.RemoveEmptyEntries);

                    foreach (string word in words)
                    {
                        string lowerWord = word.ToLower();

                        if (wordCount.ContainsKey(lowerWord))
                            wordCount[lowerWord]++;
                        else
                            wordCount[lowerWord] = 1;
                    }
                }
            }

            // Total words
            int totalWords = wordCount.Values.Sum();
            Console.WriteLine("Total Words: " + totalWords);

            // Top 5 frequent words
            Console.WriteLine("\nTop 5 Most Frequent Words:");
            foreach (var item in wordCount
                     .OrderByDescending(w => w.Value)
                     .Take(5))
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("I/O Error: " + ex.Message);
        }
    }
}
