namespace TestingThingsOut.ValueTypes;

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