using System;

class MatrixTargetSearcher
{
    static void Main(string[] args)
    {
        int[,] matrix =
        {
            { 1, 3, 5, 7 },
            { 10, 11, 16, 20 },
            { 23, 30, 34, 60 }
        };

        int target = 16;

        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        int left = 0;
        int right = rows * cols - 1;

        bool found = false;

        while (left <= right)
        {
            int mid = (left + right) / 2;
            int r = mid / cols;
            int c = mid % cols;

            if (matrix[r, c] == target)
            {
                Console.WriteLine("Target found at: (" + r + ", " + c + ")");
                found = true;
                break;
            }

            if (matrix[r, c] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }

        if (!found)
            Console.WriteLine("Target not found");
    }
}
