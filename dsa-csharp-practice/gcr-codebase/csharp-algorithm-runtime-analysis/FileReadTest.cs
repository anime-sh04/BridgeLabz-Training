using System;
using System.Diagnostics;
using System.IO;
using System.Text;

class FileReadTest
{
    static void Main()
    {
        string path = "bigfile.txt";

        Stopwatch sw = new Stopwatch();

        // StreamReader test
        sw.Start();
        using (StreamReader sr = new StreamReader(path))
        {
            while (sr.Read() != -1) { }
        }
        sw.Stop();
        Console.WriteLine("StreamReader Time: "+sw.ElapsedMilliseconds+" ms");

        sw.Reset();

        // FileStream test
        sw.Start();
        using (FileStream fs = new FileStream(path, FileMode.Open))
        {
            byte[] buffer = new byte[8192];
            while (fs.Read(buffer, 0, buffer.Length) > 0) { }
        }
        sw.Stop();
        Console.WriteLine("FileStream Time: "+sw.ElapsedMilliseconds+" ms");

        Console.ReadLine();
    }
}
