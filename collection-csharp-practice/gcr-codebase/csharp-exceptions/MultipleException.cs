using System;

class MultipleException
{
    static void Main()
    {
        try
        {
            int[] arr = null; 
			
            Console.Write("Enter index: ");
            int index = int.Parse(Console.ReadLine());

            Console.WriteLine($"Value at index {index}: {arr[index]}");
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Invalid index!");
        }
        catch (NullReferenceException)
        {
            Console.WriteLine("Array is not initialized!");
        }
    }
}
