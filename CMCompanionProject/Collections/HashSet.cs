namespace CMCompanionProject.Collections;

public class HashSet
{
    public static void ExampleHashSet() //does not allow duplicate elements
    {
        HashSet<string> hashSet = new HashSet<string>();
        
        hashSet.Add("A");
        hashSet.Add("B");
        hashSet.Add("C");
        hashSet.Add("D");

        Console.WriteLine(hashSet.Count);
    }
}