namespace gitTrain;

using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 3, 7, 2, 9, 5 };
        
        Console.Write("Array elements: ");
        
        foreach (int n in numbers)
            {
            Console.Write(n + " ");
            }
        Console.WriteLine();
        Console.WriteLine("--------");
        Console.WriteLine("Calculated sum: " + NumCalc.Sum(numbers));
        Console.WriteLine("Average: " + NumCalc.CalculateAverage(numbers));
        Console.WriteLine("Max: " + NumCalc.CalculateMax(numbers));
        Console.WriteLine("Min: " + NumCalc.CalculateMin(numbers));
    }
}