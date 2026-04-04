using System;

class NumberOfHandshakes
{
    public static int CalculateHandshakes(int n){
        int result = (n*(n-1))/ 2;
        return result;
    }

    static void Main(string[] args){
        int students = int.Parse(Console.ReadLine());
        int handshakes = CalculateHandshakes(students);

        Console.WriteLine(handshakes);
    }
}
