namespace CM_CSharp_Course.Math;

public class CumulativeSum
{
    public static double[] CumulativeSumMethod(double[] array)
    {
        double[] cumSum = new double[array.Length];
        double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
            cumSum[i] = sum;
        }
        return cumSum;
    }

    static double[] _data = { 1, 2, 3, 4 };
    double[] _cumSum = CumulativeSumMethod(_data); // {1, 3, 6, 10}

}