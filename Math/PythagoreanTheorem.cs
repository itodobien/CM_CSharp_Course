namespace CM_CSharp_Course.Math;

public class PythagoreanTheorem
{
    public static double PythagoreanTheoremMethod(double a, double b)
    {
        return System.Math.Sqrt(a * a + b * b);
    }
    double hypotenuse = PythagoreanTheoremMethod(3, 4); // 5
}