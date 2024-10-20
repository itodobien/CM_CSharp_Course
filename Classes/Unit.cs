using CM_CSharp_Course.Interfaces;

namespace CM_CSharp_Course.Classes;

public class Unit : Inheritance, IAttackable
{
    protected float Speed;
    public int health;
    
    public Unit()
    {
        FactionName = "Example"; // these are accessible in both Player Class as well as here in Unit
        FactionType = "Generic Unit"; //These are strings from 'Inheritance' class.
    }

    public virtual void Move()
    {
        Speed += 0.1f;
        Console.WriteLine("Move Unit");
    }

    public virtual void Damage()
    {
        Console.WriteLine("Unit takes damage");
    }
}