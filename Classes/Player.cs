namespace CM_CSharp_Course.Classes;

public class Player : Unit
{
    public event EventHandler<OnPlayerDamagedEventArgs> OnPlayerDamaged;
    
    private readonly string _playerName;
    public Player(string playerName ="Code Monkey")
    {
        _playerName = playerName;
    }

    public override void Move()
    {
        Console.WriteLine("Move Player");
    }

    public override string ToString()
    {
        return "Player Name: " + _playerName;
    }
    public override void Damage()
    {
        Console.WriteLine("Damage Player");
    }

    public void PlayerSayHello()
    {
        Console.WriteLine("Hello from Player");
    }
    
    public void TakeDamage() //this could have just been an override for Damage, but I left it this way, so I wouldn't get confuses
    {
        OnPlayerDamaged?.Invoke(this, new OnPlayerDamagedEventArgs
        {
            previousHealth = 100,
        });

    }
    public void SetSpeed(int speed)
    {
        if (speed == 0)
        {
            Console.WriteLine("ERROR:: " + nameof(speed) + "Must be greater than 0");
        }
    }
}