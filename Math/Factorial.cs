namespace CM_CSharp_Course.Math;

public class Factorial
{
    public static long FactorialMethod(int n)
    {
        if (n < 0)
            throw new ArgumentException("FactorialMethod is not defined for negative numbers.");
        if (n == 0 || n == 1)
            return 1;
        long result = 1;
        for (int i = 2; i <= n; i++)
            result *= i;
        return result;
    }

    long fact = FactorialMethod(5); // 120

}