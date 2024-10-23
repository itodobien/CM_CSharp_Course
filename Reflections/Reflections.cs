using System.Reflection;

namespace CM_CSharp_Course.Reflections;

public class Reflections
{
    public void ReflectionsMainMethod()
    {
        Exercise exercise = new Exercise();
        //exercise.ExerciseMethod(); // just showing this can be done as well

        MethodInfo exerciseMethodInfo = typeof(Exercise).GetMethod("ExerciseMethod");
        exerciseMethodInfo.Invoke(exercise, new object[] { });

        foreach (Type type in typeof(Exercise).GetNestedTypes(BindingFlags.NonPublic | BindingFlags.Public))
        {
            Console.WriteLine(type);
        }
    }
    public void SecondReflectionsMethod()
    {
        Exercise exercise = new Exercise();
        
        Type playerType = typeof(Exercise).GetNestedType("Player");
        Console.WriteLine(playerType);
        
        MethodInfo myExerciseMethod2Info = playerType.GetMethod("ExerciseMethod2");
        myExerciseMethod2Info.Invoke(new Exercise.Player(), new object[] { 99 });
    }
}
public class Exercise
{
    public void ExerciseMethod() { }
    public class Player
    {
        public void ExerciseMethod2(int i)
            {
                Console.WriteLine("ExerciseMethod2 value passed:  " + i);
            }
    }
    public class Unit{ }
    public class Enemy{ }
    private class NPC{ }
}