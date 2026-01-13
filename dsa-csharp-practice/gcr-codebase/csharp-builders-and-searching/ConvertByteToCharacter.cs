using System;
using System.IO;
using System.Text;
class ConvertByteToCharacter
{
    static void Main(string[] args)
    {
        string path = "Example.txt";

        // Open file as byte stream
        FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);

        // Convert byte stream to character stream
        StreamReader reader = new StreamReader(fs, Encoding.UTF8);

        int ch;
        while ((ch = reader.Read()) != -1)
        {
            Console.Write((char)ch);
        }

        reader.Close();
        fs.Close();
    }
}
