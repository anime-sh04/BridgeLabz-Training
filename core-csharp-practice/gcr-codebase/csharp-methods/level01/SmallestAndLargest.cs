using System;

class SmallestLargest
{
    public static int[] FindSmallestAndLargest(int number1, int number2, int number3){
        int smallest = number1; // assume
        int largest = number1; // assume

        if (number2 <smallest)
            smallest = number2;

        if (number3 <smallest)
            smallest = number3;

        if (number2 >largest)
            largest = number2;

        if (number3 >largest)
            largest = number3;

        int[] result = new int[2];
        result[0] = smallest;
        result[1] = largest;

        return result;
    }

    static void Main(string[] args){
        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());
        int n3 = int.Parse(Console.ReadLine());

        int[] answer = FindSmallestAndLargest(n1,n2,n3);

        Console.WriteLine("Smallest: "+answer[0]);
        Console.WriteLine("Largest: "+answer[1]);
    }
}
