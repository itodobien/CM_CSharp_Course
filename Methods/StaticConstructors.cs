namespace CM_CSharp_Course.Methods;

public class StaticConstructors
{
    public void StaticConstructorMainMethod()
    {
        Player player = new Player();
        Console.WriteLine(Player.i);
        Player.TestFunction();
    }
}

public class Player
{
    public static int i;
    
    static Player() // static constructor will run only once but will always run the one time
    {
        Console.WriteLine("Player static constructor");
        i = 23;
    }

    public static void TestFunction()
    {
        Console.WriteLine("TestFunction");
    }

    public Player()
    {
        Console.WriteLine("Player constructor");
    }
}