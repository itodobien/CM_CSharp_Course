using CM_CSharp_Course.Interfaces;

namespace CM_CSharp_Course.Classes;


public class Interactions : IAttackable
{
    private IAttackable _attackablePlayer = new Player("Code Monkey");
    private IAttackable _attackableEnemy = new Enemy();

    public void PlayerDamage()
    {
        _attackablePlayer.Damage();
    }

    public void EnemyDamage()
    {
        _attackableEnemy.Damage();
    }

    public void Damage()
    {
        Console.WriteLine("Damage");
    }

    public void TriggerAllDamage()
    {
        
        Console.WriteLine("Calling Damage base method:");
        Damage();
        Console.WriteLine();

        Console.WriteLine("Calling Damage on Player:");
        PlayerDamage();
        Console.WriteLine();

        Console.WriteLine("Calling Damage on Enemy:");
        EnemyDamage();
    }

    public void AttackObject(IAttackable attackable) 
    {
        attackable.Damage();
    }
    
}
