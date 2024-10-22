namespace CM_CSharp_Course.Generics;

public class ClassesWGenerics
{
    public void ClassesWGenericsMain()
    {
        MyList<Player2> myPlayers = new MyList<Player2>();
        myPlayers.field = new Player2();
        Console.WriteLine(myPlayers.SomeFunction());
    }
    public class MyList<T> where T : class, new() //T can only be used if T is a class and has a paramaterless constructor
    {
        public T field;
        public T SomeFunction()
        {
            return new T();
        }
    }
    private class Player2
    {
        //
    }
}