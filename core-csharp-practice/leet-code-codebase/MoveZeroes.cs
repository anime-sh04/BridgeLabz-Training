using System;

class Solution
{
    static void Main(string[] args){
		int n = int.Parse(Console.ReadLine());
        int[] nums = new int[n];
		
		for(int i=0;i<nums.Length;i++){
			nums[i] = int.Parse(Console.ReadLine());
		}

        MoveZeroes(nums);

        Console.WriteLine("Array after moving zeroes:");
        for (int i = 0; i < nums.Length; i++){
            Console.Write(nums[i] + " ");
        }
    }

    public static void MoveZeroes(int[] nums){
        int i= 0;
        for (int j=0;j<nums.Length;j++){
            if (nums[j]!= 0){
                nums[i]= nums[j];
                i++;
            }
        }

        while (i<nums.Length){
            nums[i] = 0;
            i++;
        }
    }
}
