using System;

class FiveElements
{
    static void Main(string[] args)
    {
        int[] arr = new int[5];

        for (int i =0; i<arr.Length;i++){
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 0; i < arr.Length; i++){
            int num = arr[i];
            if (num>0){
                if(num%2 ==0){
                    Console.WriteLine(num +" is Positive and Even");
                }
                else{
                    Console.WriteLine(num+" is Positive and Odd");
                }
            }
            else if (num < 0){
                Console.WriteLine(num+ " is Negative");
            }
            else{
                Console.WriteLine(num+" is Zero");
            }
        }

        if (arr[0] == arr[4]){
            Console.WriteLine("First and Last elements are Equal");
        }
        else if (arr[0] > arr[4]){
            Console.WriteLine("First element is Greater than Last element");
        }
        else{
            Console.WriteLine("First element is Less than Last element");
        }
    }
}
