using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 3, 7, 2, 9, 5 };
        
        Console.WriteLine("Numbers:");
        
        foreach (int n in numbers)
            {
            Console.Write(n + " ");
            }
        Console.WriteLine();
        Console.WriteLine("Sum: " + Sum(numbers));
    }

    static int Sum(int[] arr)
    {
        int sum = 0;

        foreach (int n in arr)
        {
            sum += n;
        }
        
        return sum;
    }
}