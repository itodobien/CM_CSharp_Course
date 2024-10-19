namespace CM_CSharp_Course.Collections;

public class Stack //First in last out
{
    public static void ExampleStack()
    {
        Stack<string> stack = new Stack<string>();
        stack.Push("A");
        stack.Push("B");
        stack.Push("C");

        Console.WriteLine(stack.Pop());
       
    }
}