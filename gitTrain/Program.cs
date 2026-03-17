namespace gitTrain;

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
        Console.WriteLine("Sum: " + NumCalc.Sum(numbers));
    }
}