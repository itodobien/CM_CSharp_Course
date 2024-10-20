namespace CM_CSharp_Course.Methods;

public class Delegates
{
    // Custom delegates
    private delegate void AttackDelegate();
    private delegate int StringToIntDelegate(string str);
    private static AttackDelegate attackAction;

    // Built-in delegates
    
    private static Action actionDelegate;
    private static Action<int> actionWithIntDelegate; // All Action delegates return void
    private static Func<int> funcReturningInt;
    

    //Assigned all of the created delegates in this function for simplicity
    public static void AssignDelegates()
    {
        // Assigning custom delegate
        attackAction = PerformMeleeAttack;
        attackAction += PerformRangedAttack;
        

        // Assigning built-in delegates
        StringToIntDelegate stringToIntDelegate = MethodWithStrParamRetruningInt;
        actionDelegate = PerformMeleeAttack;
        actionWithIntDelegate = MethodWithIntParameter;
        funcReturningInt = ReturnInt;

        // this can be commented out. Just here to see examples
        attackAction(); //this will return BOTH assigned actions
        stringToIntDelegate("example");
        actionDelegate();
        actionWithIntDelegate(10);
        int result = funcReturningInt();

        Action secondAction = () => { }; // making a delegate with no return and no params doesn't require a written method
        
        Func<int, bool> secondFunc = (int i) => //more shorthand for a delegate that takes an int and returns bool
            false;
    }

    // Methods matching delegate signatures
    private static void PerformMeleeAttack()
    {
        Console.WriteLine("This is a melee attack");
    }
    private static void PerformRangedAttack()
    {
        Console.WriteLine("This is a ranged attack");
    }

    private static int MethodWithStrParamRetruningInt(string str)
    {
        Console.WriteLine($"Converting string '{str}' to int");
        return 0; // Just returning 0 for simplicity
    }

    private static void MethodWithIntParameter(int i)
    {
        Console.WriteLine($"This method received the integer: {i}");
    }

    private static int ReturnInt()
    {
        Console.WriteLine("Returning zero");
        return 0;
    }
}