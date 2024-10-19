using System.Numerics;

namespace TestingThingsOut.Methods;


public class OptionalParams
{
    
    
    public enum UnitType
    {
        Melee,
        Ranged,
        Wizard
    }

    //optional params need to be listed last. After all of the required params.
    public static void ParamsOptionalMethod(Vector3 spawnPosition, UnitType unitType, Quaternion spawnRotation, int healthAmount = 100) // this is assigning a default to health and it's not needed when you call this method later.
    {
        Console.WriteLine($"""
                           Spawning unit of type: {unitType} with health amount: {healthAmount} at {spawnPosition}
                           """);
    }
    
    public static void ParamsOptionalMethodWithDefaults(
        Vector3 spawnPosition = default, 
        UnitType unitType = UnitType.Melee, 
        Quaternion spawnRotation = default, 
        int healthAmount = default) //having a default set allows you to call the method without having to pass anything into to params. It will create an object with the defaults of the data type
    {
        Console.WriteLine($"""
                           Spawning unit of type: {unitType} with health amount: {healthAmount} at {spawnPosition}
                           """);
    }

    private void CallMyMethods()
    {
        ParamsOptionalMethod(new Vector3(10, 10, 10), OptionalParams.UnitType.Melee, Quaternion.Identity, 100);
        ParamsOptionalMethodWithDefaults();
    }
    

    
    
}