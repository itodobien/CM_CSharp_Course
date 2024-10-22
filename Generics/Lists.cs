namespace CM_CSharp_Course.Generics;

public class Lists
{
    public static void MainListMethod()
        {
            MyList<int> myIntList = new MyList<int>();
            myIntList.field = 5;
            Console.WriteLine(myIntList.MyFunction());
            
            MyList<bool> myBoolList = new MyList<bool>();
            myBoolList.field = true;
            Console.WriteLine(myBoolList.MyFunction());
            TestListMethod(5);
            TestListMethod(true);
            TestListMethod('z');
            TestListMethod("Rando");
        }
    private struct MyStruct<T>
    {
        public T field;
    }
    private static void TestListMethod<T>(T p) // return type p
    {
        Console.WriteLine(p);
    }
    private interface MyInterface<T>
    {
        T MyFunction(); //return type of T
    }
    
}

public struct MyList<T>
{
    public T field;

    public T MyFunction()
    {
        return default;
    }
}

