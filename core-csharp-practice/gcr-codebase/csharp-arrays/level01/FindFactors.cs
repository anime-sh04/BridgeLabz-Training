using System;

class FindFactors
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int maxFactor = 10;
        int[] arr = new int[maxFactor];
		
        int index = 0;
		
        for (int i =1; i<= number; i++){
            if (number%i == 0){

                if (index == maxFactor){
                    maxFactor = maxFactor * 2;
                    int[] temp = new int[maxFactor];

                    for (int j=0; j<index; j++){
                        temp[j] = arr[j];
                    }
                    arr = temp;
                }
                arr[index] = i;
                index++;
            }
        }

        for (int i =0;i<index; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
}
