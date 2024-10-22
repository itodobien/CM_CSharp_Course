namespace CM_CSharp_Course.Classes;

public class PlayerHealthBar
{
    public PlayerHealthBar(Player player)
    {
        player.OnPlayerDamaged += Player_OnPlayerDamaged;
    }

    private void Player_OnPlayerDamaged(object? sender, OnPlayerDamagedEventArgs e)
    {
        Console.WriteLine($"Previous health: {e.previousHealth} Player_OnPlayerDamaged");
    }
}