namespace CM_CSharp_Course.Methods;

public class ExplressionBodiedmembers
{
    private string playerName;
    private int playerScore;
    public void ExpressionBodiedMembersMainMethod()
    {
        
    }

    public string GetPlayerName()
    {
        return playerName;
    }
    
    public string GetPlayerNameExpressionBody() => playerName;
    public int GetPlayerScore() => playerScore;
    public void SetPlayerName(string playerName) => this.playerName = playerName;

    public string PlayerName
    {
        get => playerName;
        set => playerName = value;
    }
    
    public ExplressionBodiedmembers(string playerName) => this.playerName = playerName; //constructor
}