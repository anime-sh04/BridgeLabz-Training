using System;
using System.IO;

class ByteArrayStream
{
    static void Main()
    {
        string sourceImage = "input.jpg";
        string outputImage = "output.jpg";

        try
        {
            // Read image into byte array
            byte[] imageBytes;
            using (FileStream fs = new FileStream(sourceImage, FileMode.Open, FileAccess.Read))
            using (MemoryStream ms = new MemoryStream())
            {
                fs.CopyTo(ms);
                imageBytes = ms.ToArray();
            }
            using (MemoryStream ms = new MemoryStream(imageBytes))
            using (FileStream fs = new FileStream(outputImage, FileMode.Create, FileAccess.Write))
            {
                ms.WriteTo(fs);
            }

            long originalSize = new FileInfo(sourceImage).Length;
            long newSize = new FileInfo(outputImage).Length;

            if (originalSize == newSize)
                Console.WriteLine("Image copied successfully. Files are identical.");
            else
                Console.WriteLine("Image copy failed. Files differ.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("I/O Error: " + ex.Message);
        }
    }
}
