namespace CM_CSharp_Course.Keywords;

public class AnonomousType
{
    public void AnonomousTypeMaionmethod()
    {
       var playerData = new {Name = "Code Monkey", Id = 23};
       Console.WriteLine(playerData); //these are read only properties
       Console.WriteLine(playerData.GetType());
       
    }
}