using CM_CSharp_Course.Classes;
using CM_CSharp_Course.Interfaces;

namespace CM_CSharp_Course.TypeCasting;

public class TypeConversion
{
    private Player player = new Player("Player Type");
    private IAttackable playerAttackable = new Player("IAttackable Type");
    private IAttackable enemyAttackable = new Enemy();
    public IAttackable attackable = new Player();

    private static int a = 5; //static used here just for readability 
    private static object obj = a; //static makes it so I don't have to create an instance of the class 
    private int b = (int) obj;
    
    public void GetAllTypes() {
        // playerAttackable.PlayerSayHello(); - this cannot be called because the Player was created through Iattackable
        Console.WriteLine(playerAttackable.GetType());
        Console.WriteLine(enemyAttackable.GetType());
        Console.WriteLine(player.GetType());
        
    }
    
    public void UsingTypeOf()
    {
        if (attackable.GetType() == typeof(Player))
        {
            Console.WriteLine("I am a Playa from the Himalaya");
        }
        else if(attackable.GetType() == typeof(Enemy))
        {
            Console.WriteLine("I am an Enemy");
        }
        else
        {
            Console.WriteLine("These are not the types you are looking for");
        }
    }

    public void UsingIsKeyword()
    {
        if (attackable is (Player))
        {
            Console.WriteLine("I am a Playa from the Himalaya");
        }
        else if(attackable is (Enemy))
        {
            Console.WriteLine("I am an Enemy");
        }
        else if (attackable.GetType().IsInterface)
        {
            Console.WriteLine("I am an interface");
        }
        else
        {
            Console.WriteLine("These are not the types you are looking for");
        }
    }

    public void UsingAsKeyword()
    {
        player = attackable as Player;
        player.PlayerSayHello();
    }

    public void CastingtoType()
    {
        player = (Player)attackable;
        player.PlayerSayHello();
    }
    
}