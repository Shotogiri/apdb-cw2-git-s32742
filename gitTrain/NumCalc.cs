namespace gitTrain;

public class NumCalc
{ 
    public static int Sum(int[] arr)
    {
        int sum = 0;

        foreach (int n in arr)
        {
            sum += n;
        }
        
        return sum;
    }
}