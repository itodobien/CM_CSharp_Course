namespace CM_CSharp_Course.Collections;

public class SortedLists
{
    public static void ExampleSortedList()
    {
        SortedList<int, string> list = new SortedList<int, string>();
        
        list.Add(2, "two");
        list.Add(3, "three");
        list.Add(1, "one");
        
        foreach (KeyValuePair<int, string> kvp in list)

        Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
    }
}