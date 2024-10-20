namespace CM_CSharp_Course.Math;

public class CompoundInterest
{
    public static double CompoundInterestMethod(double principal, double rate, int timesCompounded, double years)
    {
        return principal * System.Math.Pow(1 + rate / timesCompounded, timesCompounded * years);
    }
    private double _futureValue = CompoundInterestMethod(default, default, default, default);
}

