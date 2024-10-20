using CM_CSharp_Course.Interfaces;

namespace CM_CSharp_Course.Classes;

public class Enemy : Unit
{
    public Enemy()
    {
        FactionName = "Enemy Faction";
        Speed = default; 
    }

    public override void Move()
    {
        Console.WriteLine("Move Enemy");
    }
    
    public override void Damage()
    {
        Console.WriteLine("Damaged Enemy");
    }

    public void EnemySayHello()
    {
        Console.WriteLine("Hello from Enemy");
    }
}

public class EnemyBoss : Enemy
{
    //just an example of another layer of sub class/inheritance 
}

