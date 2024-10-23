using CM_CSharp_Course.Classes;

namespace CM_CSharp_Course.Operators;

public class NameOf
{
    public void NameOfMainMethod()
    {
        string playerClassName = nameof(Player);

        Console.WriteLine(nameof(Player));
        Console.WriteLine(nameof(Player.TakeDamage));
        Console.WriteLine(nameof(Player.health));

        Player player = new Player();
        player.SetSpeed(0);

    }
    
    /*public void SetSpeed(int speed) // this is the copied method from Player.cs in Classes. Just here for reference to see what is happeneing with 'nameof'
    {
        if (speed == 0)
        {
            Console.WriteLine("ERROR: :" + nameof(speed) + "Must be greater than 0");
        }
    }*/
    
}