namespace CM_CSharp_Course.Math;

public class Fibonacci
{
    //This returns the value of for a number at a given position(n) in the fibonacci sequence. 
    public static long FibonacciIterative(int n)
    {
        if (n < 0)
            throw new ArgumentException("Fibonacci is not defined for negative numbers.");
        if (n == 0) return 0;
        if (n == 1) return 1;

        long a = 0;
        long b = 1;
        long temp;

        for (int i = 2; i <= n; i++)
        {
            temp = a + b;
            a = b;
            b = temp;
        }

        return b; 
    }
}