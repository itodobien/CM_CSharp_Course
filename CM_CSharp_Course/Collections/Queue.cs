namespace CMCompanionProject.Collections;

public class Queue //First in First Out
{
    public static void ExampleQueue()
    {
        Queue<string> queue = new Queue<string>();
        queue.Enqueue("A");
        queue.Enqueue("B");
        queue.Enqueue("C");

        Console.WriteLine(queue.Dequeue());
    }
}