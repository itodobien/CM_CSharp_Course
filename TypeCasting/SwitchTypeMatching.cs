using CM_CSharp_Course.Classes;
using CM_CSharp_Course.Interfaces;

namespace CM_CSharp_Course.TypeCasting;

public class SwitchTypeMatching : IAttackable
{
    private IAttackable attackable = new Player()
    {
        health = 100,
    };
    
    public void Damage()
    {
        //
    }


public void SwitchTypeMatchingExample()
    {
        switch (attackable) //testing the type
        {
            default:
                break;
            case Player player when player.health < 50: // has to run before other Player case because it has more restrictions will not ever be evaluated if it's after the other case
                Console.WriteLine("Health is lower than 50%");
                player.PlayerSayHello();
                break;
            case Player player: //casts attackable onto Player type and assign 'player' as reference
                player.PlayerSayHello();
                break;
            case Enemy {health: < 50} enemy: //aternative way of writing the same 'when' statement from above
                enemy.EnemySayHello();
                break;
            case Unit unit:
                break;
        }
    }
}