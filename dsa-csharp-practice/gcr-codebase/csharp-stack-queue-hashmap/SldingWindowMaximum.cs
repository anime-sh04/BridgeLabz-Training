using System;

class SlidingWindowMaximum
{
    static int[] MaxSlidingWindow(int[] nums, int k)
    {
        int n = nums.Length;
        int[] result = new int[n - k + 1];

        int[] dq = new int[n];
        int front = 0, rear = -1;

        int ri = 0;

        for (int i = 0; i < n; i++)
        {
            if (front <= rear && dq[front] <= i - k)
                front++;

            while (front <= rear && nums[dq[rear]] < nums[i])
                rear--;

            dq[++rear] = i;

            if (i >= k - 1)
                result[ri++] = nums[dq[front]];
        }

        return result;
    }

    static void Main()
    {
        int[] nums = { 1, 3, -1, -3, 5, 3, 6, 7 };
        int k = 3;

        int[] ans = MaxSlidingWindow(nums, k);

        Console.WriteLine("Sliding Window Maximum:");
        for (int i = 0; i < ans.Length; i++)
            Console.Write(ans[i] + " ");
    }
}
