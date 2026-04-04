using System;
using System.IO;

class ReadAndWriteTextFile
{
    static void Main()
    {
        string sourceFile = "input.txt";
        string destinationFile = "output.txt";

        try
        {
            if (!File.Exists(sourceFile))
            {
                Console.WriteLine("Source file does not exist.");
                return;
            }

            // FileStream for reading and writing
            using (FileStream fsRead = new FileStream(
                sourceFile, FileMode.Open, FileAccess.Read))
            using (FileStream fsWrite = new FileStream(
                destinationFile, FileMode.Create, FileAccess.Write))
            {
                int byteData;
                while ((byteData = fsRead.ReadByte()) != -1)
                {
                    fsWrite.WriteByte((byte)byteData);
                }
            }

            Console.WriteLine("File copied successfully.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("I/O Error: " + ex.Message);
        }
    }
}
