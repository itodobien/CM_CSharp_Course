namespace CM_CSharp_Course.Collections;

public class Loops
{
    int randomNumber = 0;
    int maxNumber = 0;
    
    public void WhileLoop()
    {
        while (randomNumber < maxNumber)
        {
            randomNumber++;
        }
    }
    
    public int RecursionIncrementer(int randomNumber)
    {
        if (randomNumber < maxNumber)
        {
            return RecursionIncrementer(randomNumber +1);
        }
        else
        {
            return randomNumber;
        }
    }
}