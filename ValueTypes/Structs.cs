namespace CM_CSharp_Course.ValueTypes;

public class Structs
{
    public static void StructDemo()
    {
        PlayerStruct playerStruct = new PlayerStruct();
        playerStruct.a = 5;
        
        PlayerClass playerClass = new PlayerClass();
        playerClass.a = 5;
        
        TestStructMethod(playerStruct);
        TestClassMethod(playerClass);

        Console.WriteLine($"""
                          Player struct value: {playerStruct.a}
                          Player class value: {playerClass.a}
                          """ );
    }
    
    public struct StructConstructorExample
    {
        public string name;
        public int age;

        public StructConstructorExample(string name, int age)
        {
            this.name = name;
            this.age = age;
            Console.WriteLine($"""
                              Name: {name}
                              Age: {age}
                              """);
        }
        
    }

    struct StructSecondConstructorExample
    {
        public int x;
        public int y;
    }
    
    private StructSecondConstructorExample structSecondConstructorExample;

    private void CallStructFromAbove()
    {
        structSecondConstructorExample = new StructSecondConstructorExample()
        {
            x = 1,
            y = 2,

        };
    }
    
    public static void TestStructMethod(PlayerStruct playerStruct)
    {
        playerStruct.a = 500;
    }

    public static void TestClassMethod(PlayerClass playerClass)
    {
        playerClass.a = 500;
    }

    public struct PlayerStruct()
    {
        public string name;
        public int a;
    }
    
    public class PlayerClass()
    {
        public int a;
        public string name;
    }
}