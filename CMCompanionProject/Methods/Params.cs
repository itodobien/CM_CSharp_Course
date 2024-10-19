namespace TestingThingsOut.Methods;

public class Params
{
    
    public static void ExampleStringParam(params string[] playerNameArray)
    {
        Console.WriteLine($"Player name: {string.Join(", ", playerNameArray)}");
    }
}