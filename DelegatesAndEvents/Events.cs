using CM_CSharp_Course.Classes;

namespace CM_CSharp_Course.Methods;

public class Events
{

    public void MainEvent()
    {
        Player player = new Player();
        PlayerHealthBar playerHealthBar = new PlayerHealthBar(player);
        player.TakeDamage();
    }
    
}

