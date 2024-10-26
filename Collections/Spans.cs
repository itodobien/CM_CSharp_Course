namespace CM_CSharp_Course.Collections;

public class Spans
{
    public void SpansMainMethod()
    {
        int[] numberArray = { 12, 2, 3, 4, 5, 10, 24, 55, 68, 54, 6 };
        //int[] subArray = new int[numberArray.Length - 2];

        Span<int> intSpan = new Span<int>(numberArray, 1, numberArray.Length - 3 );
        
        intSpan.Sort();

        foreach (int number in numberArray)
        {
            Console.WriteLine(number);
        }
    }
}