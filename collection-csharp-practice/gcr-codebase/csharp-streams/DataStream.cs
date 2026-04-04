using System;
using System.IO;

class DataStream
{
    static void Main()
    {
        string filePath = "student.dat";

        try
        {
            // WRITE primitive data to binary file
            using (FileStream fsWrite = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            using (BinaryWriter writer = new BinaryWriter(fsWrite))
            {
                writer.Write(101);            // Roll Number
                writer.Write("Animesh");        // Name
                writer.Write(8.75);           // GPA
            }

            // READ primitive data from binary file
            using (FileStream fsRead = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            using (BinaryReader reader = new BinaryReader(fsRead))
            {
                int rollNo = reader.ReadInt32();
                string name = reader.ReadString();
                double gpa = reader.ReadDouble();

                Console.WriteLine("Student Details:");
                Console.WriteLine("Roll No: " + rollNo);
                Console.WriteLine("Name: " + name);
                Console.WriteLine("GPA: " + gpa);
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("I/O Error: " + ex.Message);
        }
    }
}
