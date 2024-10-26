namespace CM_CSharp_Course.Keywords;

public class Tuples
{
    public void TuplesMainMethod()
    {
        var myTuple = ("Code Monkey", 56);

        Console.WriteLine(myTuple);
        var tuple = GetTuple();
        Console.WriteLine(tuple);

        (string playerName, int value) = tuple;
        Console.WriteLine(playerName);
    }

    public static (string, int) GetTuple()
    {
        return ("Iron Man", 42);
    }
}