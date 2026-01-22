using System;
using System.Diagnostics;
using System.IO;

class BufferedVsUnbuffered
{
    static void Main()
    {
        string sourceFile = "largefile.dat";
        string unbufferedDest = "unbuffered_copy.dat";
        string bufferedDest = "buffered_copy.dat";

        CopyWithoutBuffer(sourceFile, unbufferedDest);
        CopyWithBuffer(sourceFile, bufferedDest);
    }

    // Unbuffered FileStream copy
    static void CopyWithoutBuffer(string source, string destination)
    {
        Stopwatch sw = Stopwatch.StartNew();

        using (FileStream fsRead = new FileStream(source, FileMode.Open, FileAccess.Read))
        using (FileStream fsWrite = new FileStream(destination, FileMode.Create, FileAccess.Write))
        {
            byte[] buffer = new byte[4096];
            int bytesRead;

            while ((bytesRead = fsRead.Read(buffer, 0, buffer.Length)) > 0)
            {
                fsWrite.Write(buffer, 0, bytesRead);
            }
        }

        sw.Stop();
        Console.WriteLine("Unbuffered FileStream Time: " + sw.ElapsedMilliseconds + " ms");
    }

    // BufferedStream copy
    static void CopyWithBuffer(string source, string destination)
    {
        Stopwatch sw = Stopwatch.StartNew();

        using (FileStream fsRead = new FileStream(source, FileMode.Open, FileAccess.Read))
        using (BufferedStream bsRead = new BufferedStream(fsRead, 4096))
        using (FileStream fsWrite = new FileStream(destination, FileMode.Create, FileAccess.Write))
        using (BufferedStream bsWrite = new BufferedStream(fsWrite, 4096))
        {
            byte[] buffer = new byte[4096];
            int bytesRead;

            while ((bytesRead = bsRead.Read(buffer, 0, buffer.Length)) > 0)
            {
                bsWrite.Write(buffer, 0, bytesRead);
            }
        }

        sw.Stop();
        Console.WriteLine("BufferedStream Time: " + sw.ElapsedMilliseconds + " ms");
    }
}
