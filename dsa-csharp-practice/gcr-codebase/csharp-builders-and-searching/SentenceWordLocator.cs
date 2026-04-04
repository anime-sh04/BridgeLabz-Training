using System;

class SentenceWordLocator
{
    static void Main(string[] args)
    {
        string[] sentences =
        {
            "C# is powerful",
            "Learning programming is fun",
            "Data structures are important",
            "Linear search is simple"
        };

        string target = "programming";
        int index = -1;

        for (int i = 0; i < sentences.Length; i++)
        {
            if (sentences[i].Contains(target))
            {
                index = i;
                break;
            }
        }

        if (index != -1)
            Console.WriteLine("Sentence found: " + sentences[index]);
        else
            Console.WriteLine("No sentence contains the word");
    }
}
