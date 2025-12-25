using System;

class Handshakes
{
    static void Main(string[] args)
    {
        int numberOfStudents = int.Parse(Console.ReadLine());
        int handshakes = (numberOfStudents*(numberOfStudents-1)) / 2;

        Console.WriteLine(handshakes);
    }
}
