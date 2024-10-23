using CM_CSharp_Course.Methods;
using CM_CSharp_Course.Reflections;

namespace CM_CSharp_Course.Operators;

public class TypeOf
{
    public void TypeOfMainMethod()
    {
        typeof(Player).GetMethod("TakeDamage");
        
        Player player = new Player();

        player.GetType();
    }
}

