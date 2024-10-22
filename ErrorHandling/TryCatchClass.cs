namespace CM_CSharp_Course.ErrorHandling;

public class TryCatchClass
{
    public void ErrorHandlingMain()
    {
        try
        {
            int a = 0;
            int b = 1 / a;
            Console.WriteLine("Should not print");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("DivideByZeroException");
        }
        catch (Exception exception) when
            (exception is DivideByZeroException) //this is the same functionality as the catch above
        {
            Console.WriteLine(exception.Message + " " + exception.StackTrace);
        }
        finally //this will ALWAYS run. even after 'return' is used.
        {
            Console.WriteLine("Finally");
        }
        Console.WriteLine("This should still print");
            
    }

    public void ThrowException()
    {
        throw new Exception("Here's and exception");
    }
}

public class InvalidPlayerNameException : Exception
{
    private InvalidPlayerNameException(string invalidPlayerName)
    {
        //Constructor needed here to enable params for custom exception
    }

    public void CustomException()
    {
        throw new InvalidPlayerNameException("Invalid player name");
    }
}