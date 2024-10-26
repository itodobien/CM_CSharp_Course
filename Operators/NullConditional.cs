using Player = CM_CSharp_Course.Classes.Player;

namespace CM_CSharp_Course.Operators;

public class NullConditional
{
    public void NullConditionalMainMethod()
    {
        Player player = new Player();
        Console.WriteLine(player?.ToString());
        
        List<string> playerNames = new List<string>() { "null", "ned" };
        playerNames?.ForEach(player => Console.WriteLine(player?.ToString()));
        
        List<Player> players = new List<Player>() {new Player("Louie Lunchmeat")};
        Console.WriteLine(players?[0]);
    }

    public void ShowNullConditionalWhenValueIsNull()
    {
        Player player = null;
        Console.WriteLine(player?.ToString());
    }
}