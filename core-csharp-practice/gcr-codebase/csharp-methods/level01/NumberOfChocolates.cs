using System;

class NumberOfChocolates
{
    public static int[] Chocolates(int numberOfChocolates, int numberOfChildren){
        int gets = numberOfChocolates/numberOfChildren;
        int remaining = numberOfChocolates%numberOfChildren;

        int[] result = new int[2];
        result[0] = gets;
        result[1] = remaining;

        return result;
    }

    static void Main(string[] args){
        int numberOfChocolates = int.Parse(Console.ReadLine());
        int numberOfChildren = int.Parse(Console.ReadLine());

        int[] answer = Chocolates(numberOfChocolates,numberOfChildren);

        Console.WriteLine("Each child gets: "+answer[0]);
        Console.WriteLine("Remaining chocolates: "+answer[1]);
    }
}
