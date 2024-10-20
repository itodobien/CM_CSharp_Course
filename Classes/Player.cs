namespace CM_CSharp_Course.Classes;

public class Player : Unit
{
    
    
    private string _playerName;
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
    
}