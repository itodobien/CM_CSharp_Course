using Newtonsoft.Json.Linq;

namespace CM_CSharp_Course.Keywords;

public class Dynamics
{
    private static string json = 
        "{ " +
        "   \"assets\": [" +
        "       { \"type\": \"texture\", \"name\": \"player\", \"path\": \"textures/player.png\" }," +
        "       { \"type\": \"sound\", \"name\": \"background\", \"path\": \"sounds/bg_music.mp3\" }," +
        "       { \"type\": \"model\", \"name\": \"enemy\", \"path\": \"models/enemy.obj\" }" +
        "   ]" +
        "}";

    
    public void DynamicsMainMethod()
    {
        dynamic d;
        var v = 56;
        dynamic jsonDynamic = JObject.Parse(json);
        Console.WriteLine(jsonDynamic.assets[0].type);

        dynamic dynamicTest = Test();
        Console.WriteLine(dynamicTest.name);
    }

    private static dynamic Test()
    {
        // return 12f; //can return anytype
        return new {name = "Code Monkey", health = 100}; 
    }
}