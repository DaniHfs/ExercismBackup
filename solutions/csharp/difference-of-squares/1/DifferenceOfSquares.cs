public static class DifferenceOfSquares
{   
    // using Faulhaber's Formula to calculate the sums
    // using long to prevent overflow if n gets big
    
    public static long CalculateSquareOfSum(int n)
    {
        long sum = (long)n * (n + 1) / 2;
        
        return sum * sum;
    }

    public static long CalculateSumOfSquares(int n)
    {
        long ln = (long)n;
            
        return ln * (ln + 1) * (2*ln + 1) / 6;
    }
        

    public static long CalculateDifferenceOfSquares(int n)
        => CalculateSquareOfSum(n) - CalculateSumOfSquares(n);
}