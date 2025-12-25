using System;

class NumberCheck
{
    public static int CheckValue(int number){
        if (number>0)
            return 1;
        else if (number<0)
            return -1;
        else
            return 0;
    }

    static void Main(string[] args){
        int num = int.Parse(Console.ReadLine());

        int result = CheckValue(num);

        Console.WriteLine(result);
    }
}
