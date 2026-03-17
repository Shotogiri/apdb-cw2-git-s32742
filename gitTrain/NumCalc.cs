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
}