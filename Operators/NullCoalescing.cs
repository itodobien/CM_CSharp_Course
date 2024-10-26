namespace CM_CSharp_Course.Operators;

public class NullCoalescing
{
    private static string playerName;
    private static string player2Name;
    public void NullCoalescingMainMethod()
    {
        int playerNameLength;
        int player2NameLength;
        
        player2Name = "Code Monkey";

        /*if (playerName == null)
        {
            playerNameLength = GetStringLength("");
        }
        else
        {
            playerNameLength = GetStringLength(playerName);
        }*/
        playerNameLength = GetStringLength(playerName?? "");// this does everthing the above if/else does.
        
        ThesePlayers thesePlayers = null;
        
        //thesePlayers ??= new ThesePlayers();
        
        
        player2NameLength = GetStringLength(player2Name?? "");
        Console.WriteLine(playerNameLength);
        Console.WriteLine(player2NameLength);
        
        Console.WriteLine(thesePlayers?.GetPlayerName() ?? "Unknown player");
    }

    private static int GetStringLength(string str)
    {
        return str.Length;
    }
}

public class ThesePlayers
{
    private List<ThesePlayers> playerTargetList;

    public void AddTargetPlayer(ThesePlayers targetPlayer)
    {
        playerTargetList ??= new List<ThesePlayers>(); //list is not initialized above and this will initialize it
        playerTargetList.Add(targetPlayer);
    }

    public string GetPlayerName()
    {
        return "";
        
    }
}