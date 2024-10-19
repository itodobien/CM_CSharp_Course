namespace TestingThingsOut.ReferenceTypes;

public class Classes
{
    public static void ClassesDemoMethod()
    {
        int a = 5;
        
        MyClass myClass = new MyClass();
        myClass.a = 7;
        MyClass mySecondClass = myClass;
        mySecondClass.a = 80; //this will be the value as it was the last time myClass.a was modified

        Console.WriteLine($"""
                          Value for myClass: {myClass.a}
                          Value for mySecondClass: {mySecondClass.a}
                          """);
        /*both classes end up with the same value because the are reference types.
        They point to the same object so it's not a copy, it gets overridden when assigned a new value
        it is not a value type which would return different values for myClass and mySecondClass*/
    }

    public static void ValueTypeDemoMethod()
    {
        int a = 5; // since this is a copy, it will stay 5
        int b = a;
        b = 10; // this is the final value for b but not for a

        Console.WriteLine($"""
                          int a = {a}
                          int b = {b}
                          """ );
    }

    public static void StructsDemoMethod()
    {
        int a = 5;
        
        MyStruct myStruct = new MyStruct();
        myStruct.a = 7;
        MyStruct mySecondStruct = myStruct;
        mySecondStruct.a = 80; //this is a copy so it does not overwrite myStruct.a. 

        Console.WriteLine($"""
                           Value for myStruct: {myStruct.a}
                           Value for mySecondStruct: {mySecondStruct.a}
                           """);
    }
}

public class MyClass
{
    public int a;
}
public struct MyStruct
{
    public int a;
}