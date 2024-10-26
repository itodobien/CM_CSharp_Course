namespace CM_CSharp_Course.Methods;

public class AsyncAwaitTask
{
    private static string serverReturnData;
    public async Task AsyncMainMethod() //this will not work properly unless you modify Main which I don't really want to mess with right now
    {
        await ContactWebServer();
        int dataLength = serverReturnData.Length;
        Console.WriteLine($"Server data length: {dataLength}");
    }

    public static async Task ContactWebServer()
    {
        Console.WriteLine("ContactingServer...");
        await Task.Delay(3000);
        serverReturnData = "Data";
        Console.WriteLine("Got Response...");
    }
}