namespace CM_CSharp_Course.Collections;

public class LINQ
{
    public void LINQMainMethod()
    {
        List<Player> playerList = new List<Player>
        {
            new Player {playerName = "Code Monkey", team = "Red"},
            new Player {playerName = "Iron Man", team = "Blue"},
            new Player {playerName = "Captain America", team = "Red"},
            new Player {playerName = "Black Widow", team = "Blue"},
        };
        List<Player> redPlayerList = playerList.Where(player => player.team == "Red").ToList();
        
        //this method will SELECT everything FROM playerlist WHERE team == "Red"
        IEnumerable<Player> redPlayerIEnumerable =
            from player in playerList 
            where player.team == "Red"
                select player;
        
        foreach (Player player in redPlayerList)
        {
            Console.WriteLine(player);
        }
        foreach (Player player in redPlayerIEnumerable)
        {
            Console.WriteLine(player);
        }
        
    }
    
    public class Player
    {
        public string playerName;
        public string team;

        public override string ToString()
        {
            return playerName + ", " + team;
        }
    }
}