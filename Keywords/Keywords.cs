public class KeyWords
{
    public enum State
    {
        Idle,
        Pattrolling,
        Attacking,
    }
    public void KeywordsMainMethod()
    {
        Unit unit = new Unit();
        int healthAmount;
        unit.GetUnityState(out State state, out healthAmount, out string name);
        Console.WriteLine(state + " " + healthAmount + " " + name);
    }
    public class Unit
    {
        public void GetUnityState(out State state, out int healthAmount, out string name)
        {
            healthAmount = 23;
            state = State.Idle;
            name = "Code Monkey";
        }
    }
}

