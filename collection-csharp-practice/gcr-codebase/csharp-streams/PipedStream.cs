using System;
using System.IO;
using System.IO.Pipes;
using System.Text;
using System.Threading;

class PipedStream
{
    static void Main()
    {
        try
        {
            using (AnonymousPipeServerStream pipeServer =
                   new AnonymousPipeServerStream(PipeDirection.Out,
                   HandleInheritability.Inheritable))
            {
                using (AnonymousPipeClientStream pipeClient =
                       new AnonymousPipeClientStream(PipeDirection.In,
                       pipeServer.ClientSafePipeHandle))
                {
                    Thread writerThread = new Thread(() => WriteData(pipeServer));
                    Thread readerThread = new Thread(() => ReadData(pipeClient));

                    writerThread.Start();
                    readerThread.Start();

                    writerThread.Join();
                    readerThread.Join();
                }
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("I/O Error: " + ex.Message);
        }
    }

    static void WriteData(AnonymousPipeServerStream pipeServer)
    {
        try
        {
            using (StreamWriter writer =new StreamWriter(pipeServer, Encoding.UTF8))
            {
                writer.AutoFlush = true;
                writer.WriteLine("Hello from Writer Thread");
                writer.WriteLine("Piped Stream Communication");
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("Write Error: " + ex.Message);
        }
    }

    static void ReadData(AnonymousPipeClientStream pipeClient)
    {
        try
        {
            using (StreamReader reader =
                   new StreamReader(pipeClient, Encoding.UTF8))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine("Reader Thread Received: " + line);
                }
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("Read Error: " + ex.Message);
        }
    }
}
