namespace CM_CSharp_Course.Operators;

public class TernaryConditionals
{
    int health;
    
    public void TernaryConditionalsMainMethod()
    {
        
        
    }

    public string GetPlayerStateString()
    {
        return health > 0 ? "Alive" : "Dead"; // this does the same as the code below

        if (health > 0)
        {
            return "Alive";
        }
        else
        {
            return "Dead";
        }
    }
}