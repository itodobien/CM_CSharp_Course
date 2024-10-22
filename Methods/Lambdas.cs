namespace CM_CSharp_Course.Methods;

public class Lambdas
{
    
    private void ListOfLambdas()
    {
        
        Action myAction = () => { };
        Action<string> greeting = (name) => Console.WriteLine($"Hello, {name}");
        Func<int, int> square = (x) => x * x;
        Func<int, int> square2 = delegate(int x) { return x * x; };// to help visualise the difference in identical functions
        Func<int, bool> isEven = (n) => n % 2 == 0; // takes an integer (n) and returns true if n is even, and false otherwise if odd

    }
    
    void DoSomething(Action action)
    {
        action();
    }

    void PrintHello()
    {
        Console.WriteLine("Hello!");
    }

    void CallTheAboveMethods()
    {
        DoSomething(PrintHello);
    }
    
    // DoSomething(() => Console.WriteLine("Hello!")); This one line is the same function as the last 3 methods combined. 
    
}