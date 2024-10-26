namespace CM_CSharp_Course.Classes;

public class ClassIndexer
{
    public void ClassIndexerMainmethod()
    {
        PlayerStats playerStats = new PlayerStats
        {
            strAmount = 44,
            wisAmount = 55,
            dexAmount = 23,
        };

        int strength = playerStats[0];
        int dexterity = playerStats[1];
        int wisdom = playerStats[2];

        Console.WriteLine($"The strength is {strength}.");

        playerStats[0] = 99;
        Console.WriteLine(playerStats[0]);
    }
}
public class PlayerStats
{
    public enum Stat
    {
        Str,
        Dex,
        Wis
    }
    public int strAmount;
    public int dexAmount;
    public int wisAmount;

    public int this[int index]
    {
        get
        {
            switch (index)
            {
                case 0: return strAmount;
                case 1:return dexAmount;
                case 2:return wisAmount;
                default: throw new IndexOutOfRangeException();
            }
        }
        set
        {
            switch (index)
            {
                case 0: strAmount = value; break;
                case 1: dexAmount = value; break;
                case 2: wisAmount = value; break;
                default: throw new IndexOutOfRangeException();
            }
        }
    }
}