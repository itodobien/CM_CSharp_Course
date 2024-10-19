namespace CMCompanionProject.Collections;

public class Factorial
{
    private int FactorialMethod(int n)
    {
        if (n <= 1)
        {
            return 1;
        }
        else
        {
            return n * FactorialMethod(n - 1);
        }
    }
}