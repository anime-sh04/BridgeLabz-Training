using System;

class FrequencyOfEachDigit
{
    static void Main(string[] args){
        long number = long.Parse(Console.ReadLine());
		int[] frequency = new int[10];
        long temp = number;
        int count = 0;

        while (temp!= 0){
            count++;
            temp = temp/10;
        }
        int[] digits = new int[count];
        temp =number;

        for (int i=count-1;i>=0;i--){
            digits[i] = (int)(temp % 10);
            temp /= 10;
        }
        
        for (int i =0;i <count;i++){
            int d = digits[i];
            frequency[d]++;
        }
        for (int i= 0; i<10;i++){
            if (frequency[i]> 0)
                Console.WriteLine("Digit "+i+" occurs "+frequency[i]+" time");
        }
    }
}
