namespace CM_CSharp_Course.Enums;

public class EnumFlags
{
    [Flags]
    public enum Ability
    {
        None = 0,
        Jump = 1 << 0,
        Sprint = 1 << 1,
        Shoot = 1 << 2,
        Fly = 1 << 3
    }

    public void EnumFlagsMainMethod()
    {
        Ability playerAbility = Ability.Jump | Ability.Shoot;
        Console.WriteLine(playerAbility);

        Console.WriteLine(playerAbility.HasFlag(Ability.Jump)); // this 
        Console.WriteLine((Ability.Jump & playerAbility) == Ability.Jump); // the above and this are doing the same thing. This one with binary math
    }
}