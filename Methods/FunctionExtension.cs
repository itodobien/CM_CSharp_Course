using UnityEngine;

namespace CM_CSharp_Course.Methods;

public class FunctionExtensions : MonoBehaviour
{
    private void Start()
    {
        MyTransform myTransform = null;
        myTransform.MoveRight();
        
        transform.MoveRight(3f);
        // TransformExtensions.MoveRight(transform); this does the same thing as above
        
        bool b = false;
        b.IsTrue();
    }
}

public static class TransformExtensions
{
    public static void MoveRight(this Transform transform, float amount)
    {
        transform.position += new Vector3(1, 0, 0) * amount; 
    }

    public static bool IsTrue(this bool b)
    {
        return b;
    }
}

public class MyTransform
{
    public Vector3 position;
    
    public void MoveRight()
    {
        position += new Vector3(1, 0, 0);
    }
}