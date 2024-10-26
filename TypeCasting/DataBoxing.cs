namespace CM_CSharp_Course.TypeCasting;

public class DataBoxing
{

    public void DataBoxingMainMethod()
    {
        int i = 23;
        object o = i;
        i = (int)o; //casting back into an int
    }
    
}