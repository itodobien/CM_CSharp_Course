using UnityEngine;

namespace CM_CSharp_Course.DesignPatterns;

public class SingletonPattern
{
    public void SingletonMethod()
    {
        Console.WriteLine(GameManager.Instance);
    }
}

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new GameManager();
            }
            return instance;
        }
        private set
        {
            instance = value;
        }
    }
    private GameManager() //private constructor to keep GameManager from being created elsewhere
    {
    }
    public void YeOldeSingletonMethod()
    {
        Console.WriteLine("""
                          if you're seeing this you were able to aceess a method in the 
                          GameManager class from the SingletonPattern class.
                          """);
    }
    
    /*public static GameManager Instance { get; private set; } //this is the singleton inside unity

    private void Awake()
    {
        if (Instance != null)
        {
            Debug.LogWarning("More than one instance of GameManager!");
        }    
        Instance = this;
    }*/
}