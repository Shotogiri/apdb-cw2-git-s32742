namespace gitTrain;

public class NumCalc
{ 
    public static int Sum(int[] arr)
    {
        if (arr.Length == 0)
        {
            return 0;
        }
        
        int sum = 0;

        foreach (int n in arr)
        {
            sum += n;
        }
        
        return sum;
    }

    public static double CalculateAverage(int[] arr)
    {
        if (arr.Length == 0)
        {
            return 0;
        }
        
        return (double)Sum(arr) / arr.Length;
    }

    public static int CalculateMax(int[] arr)
    {
        if (arr.Length == 0)
        {
            return 0;
        }
        
        int max = arr[0];

        foreach (int n in arr)
        {
            if (n > max)
            {
                max = n;
            }
        }
        return max;
    }
}