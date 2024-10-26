namespace CM_CSharp_Course.MultiThread;

public class MultiThreadCoding
{

    private static int resourceAmount;
    private static object resourceLock = new object();
    public void MultiThreadMainMethod()
    {
        /*Thread workerThread = new Thread(new ThreadStart(CalculatePathfinding));
        workerThread.Start();

        Console.WriteLine("Main thread started");
        workerThread.Join();

        Console.WriteLine("Main thread done");*/
        
        Thread[] threadArray = new Thread[10];
        for (int i = 0; i < threadArray.Length; i++)
        {
            threadArray[i] = new Thread(AddResources);
        }
        for (int i = 0; i < threadArray.Length; i++)
        {
            threadArray[i].Start();
        }
        for (int i = 0; i < threadArray.Length; i++)
        {
            threadArray[i].Join();  
        }
        Console.WriteLine("Resource Amount:" + resourceAmount);
        return;
    }

    private static void CalculatePathfinding()
    {
        Console.WriteLine("Calculating pathfinding ...");
        Thread.Sleep(3000);
        Console.WriteLine("Calculating pathfinding done.");
    }

    private static void AddResources()
    {
        for (int i = 0; i < 10000; i++)
        {
            lock (resourceLock)
            {
                int tmpResourceAmount = resourceAmount;
                tmpResourceAmount++;
                resourceAmount = tmpResourceAmount;
            }
        }
    }
}