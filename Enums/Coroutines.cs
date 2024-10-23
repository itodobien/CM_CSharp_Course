using System.Collections;
using UnityEngine;
    
namespace CM_CSharp_Course.Enums;

public class Coroutines : MonoBehaviour
{
    public void Start()
    {
        StartCoroutine(CoroutineExample());
    }
    
    public void CoroutinesMainMethod()
    {
        
    }

    public IEnumerator CoroutineExample()
    {
        Console.WriteLine("Before");
        yield return new WaitForSeconds(3);
        Console.WriteLine("After");
    }
    
    //this is all fine it has to be ran (run?)in the unity editor and attached to a game object. I tried a workaround but I'm not smart enough
}