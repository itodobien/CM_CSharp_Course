namespace CM_CSharp_Course.Collections;

public class Loops
{
    int _randomNumber = 0;
    int _maxNumber = 0;
    
    public void WhileLoop()
    {
        while (_randomNumber < _maxNumber)
        {
            _randomNumber++;
        }
    }
    
    public int RecursionIncrementer(int randomNumber)
    {
        if (randomNumber < _maxNumber)
        {
            return RecursionIncrementer(randomNumber +1);
        }
        else
        {
            return randomNumber;
        }
    }
}