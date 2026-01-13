using System;
using System.IO;

class WriteFile
{
    static void Main(string[] args)
    {
        string path = "output.txt";

        Console.WriteLine("Enter text (type 'exit' to stop):");

        StreamWriter writer = new StreamWriter(path);

        while (true)
        {
            string input = Console.ReadLine();

            if (input.ToLower() == "exit")
                break;

            writer.WriteLine(input);
        }

        writer.Close();

        Console.WriteLine("Data written to file successfully!");

        Console.WriteLine("\nReading file content:");

        StreamReader reader = new StreamReader(path);
        string line;

        while ((line = reader.ReadLine()) != null)
        {
            Console.WriteLine(line);
        }

        reader.Close();
    }
}
