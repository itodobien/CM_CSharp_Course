using System.Security.Cryptography.X509Certificates;
using CM_CSharp_Course.Classes;

namespace CM_CSharp_Course.Operators;

public class Defaults
{
    public void DefaultsMainMethod()
    {
        Player player = new Player();
        int i = 1;
        switch (i)
        {
            default:
                break;
            case 56:
                break;
        }
        
        Console.WriteLine(default(int)); // 0
        Console.WriteLine(default(bool)); // null
        Console.WriteLine(default(Player)); //null
        float f = default;
        Console.WriteLine(f); // 0 inferred by compiler

        Console.WriteLine(new Box<int>().GetDefault());
        Console.WriteLine(new Box<bool>().GetDefault());
        Console.WriteLine(new Box<Player>().GetDefault());
    }
    public void SetHeight(int height = default) 
    {
        
    }
}
public class Box<T>
{
    public T GetDefault()
    {
        return default;
    }
}