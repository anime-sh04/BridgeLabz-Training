using System;

class PlusOne{
    public static int[] Plus(int[] digits){
        for(int i=digits.Length-1;i>=0;i--){
            if((digits[i]+1) !=10){
                digits[i] +=1;
                return digits;
            }
            digits[i]= 0;
        }

        int[] newDigits = new int[digits.Length+1];
        newDigits[0] =1;
        return newDigits;
    }

    static void Main(){
        Console.Write("Enter number of digits: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] digits = new int[n];

        Console.WriteLine("Enter digits:");
        for(int i=0;i<n;i++){
            digits[i] = int.Parse(Console.ReadLine());
        }
        int[] result = Plus(digits);

        Console.Write("Result: ");
        for(int i=0;i<result.Length;i++){
            Console.Write(result[i] + " ");
        }
    }
}
