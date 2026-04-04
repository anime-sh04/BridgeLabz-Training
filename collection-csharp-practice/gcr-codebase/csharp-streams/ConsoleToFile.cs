using System;
using System.IO;

class ConsoleToFile
{
    static void Main()
    {
        string filePath = "OutputOfConsoleToFile.txt";

        try
        {
            // StreamReader for console input
            using (StreamReader reader =
                   new StreamReader(Console.OpenStandardInput()))
            // StreamWriter for file output
            using (StreamWriter writer =
                   new StreamWriter(filePath))
            {
                Console.Write("Enter your name: ");
                string name = reader.ReadLine();

                Console.Write("Enter your age: ");
                string age = reader.ReadLine();

                Console.Write("Enter your favorite programming language: ");
                string language = reader.ReadLine();

                writer.WriteLine("Name: " + name);
                writer.WriteLine("Age: " + age);
                writer.WriteLine("Favorite Language: " + language);
            }

            Console.WriteLine("User data saved successfully.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("I/O Error: " + ex.Message);
        }
    }
}
