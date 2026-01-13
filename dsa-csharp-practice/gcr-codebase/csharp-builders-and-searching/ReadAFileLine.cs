using System;
using System.IO;

class ReadAFileLine
{
    static void Main(string[] args)
    {
        string path = "Example.txt";

        StreamReader reader = new StreamReader(path);

        string line;

        while ((line = reader.ReadLine()) != null)
        {
            Console.WriteLine(line);
        }

        reader.Close();
    }
}
