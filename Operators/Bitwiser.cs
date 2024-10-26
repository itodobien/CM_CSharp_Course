namespace CM_CSharp_Course.Operators;

public class Bitwiser
{
    public void BitwiserMainMethod()
    {
        int a = 2;
        int b = 3;
        int c = 5;

        Console.WriteLine(a & b); // 2 '00000010' both a and b bits must = 1 to be counted (AND)
        Console.WriteLine(a | c); // 7 '00000111' either a or c bits can be = 1 for them to be counted (OR)
        Console.WriteLine(a ^ b); // 1 '00000001' if both a and b bits are = 1 then they are not counted but if a or b bit is = 1 then it is counted (XOR)
        Console.WriteLine(~a); // -3 somehow? sets each bot to 1 if either of a or b bits = 1 so this would be 3 but the first bit makes it negative
        
        
    }
}