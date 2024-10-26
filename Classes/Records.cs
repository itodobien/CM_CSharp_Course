namespace CM_CSharp_Course.Classes;

public class Records
{
    public void RecordsMainMethod()
    {
        Person person = new ("John", "Doe");
        Person person2 = person with {LastName = "Smith"};
        Console.WriteLine(person);
        Console.WriteLine(person2);
    }
    public record Person(string FirstName, string LastName);
    
    public class PersonClass // same as the above record
    {
        public string FirstName { get; init; }
        public string LastName { get; init; }
    }
}