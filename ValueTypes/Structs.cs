namespace CM_CSharp_Course.ValueTypes;

public class Structs
{
    public static void StructDemo()
    {
        PlayerStruct playerStruct = new PlayerStruct();
        playerStruct.A = 5;
        
        PlayerClass playerClass = new PlayerClass();
        playerClass.A = 5;
        
        TestStructMethod(playerStruct);
        TestClassMethod(playerClass);

        Console.WriteLine($"""
                          Player struct value: {playerStruct.A}
                          Player class value: {playerClass.A}
                          """ );
    }
    
    public struct StructConstructorExample
    {
        public string Name;
        public int Age;

        public StructConstructorExample(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            Console.WriteLine($"""
                              Name: {name}
                              Age: {age}
                              """);
        }
        
    }

    struct StructSecondConstructorExample
    {
        public int X;
        public int Y;
    }
    
    private StructSecondConstructorExample _structSecondConstructorExample;

    private void CallStructFromAbove()
    {
        _structSecondConstructorExample = new StructSecondConstructorExample()
        {
            X = 1,
            Y = 2,

        };
    }
    
    public static void TestStructMethod(PlayerStruct playerStruct)
    {
        playerStruct.A = 500;
    }

    public static void TestClassMethod(PlayerClass playerClass)
    {
        playerClass.A = 500;
    }

    public struct PlayerStruct()
    {
        public string Name;
        public int A;
    }
    
    public class PlayerClass()
    {
        public int A;
        public string Name;
    }
}