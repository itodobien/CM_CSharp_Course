namespace CM_CSharp_Course.Collections;

public class Arrays
{
    int[,] _thisArrayHasTwoDimensions = new int[1, 1];
    int[,] _thisArrayHasTwoDimensionsAsWell = new int[4, 4];
    
    public void Iterate2DArray()
    {
        for (int i = 0; i < _thisArrayHasTwoDimensions.GetLength(0); i++)
        {
            for (int j = 0; j < _thisArrayHasTwoDimensions.GetLength(1); j++)
            {
                Console.WriteLine(i + ", " + ": " + _thisArrayHasTwoDimensions[i, j]);
            }
        }
    }
    
    int [][] _arrayOfArrays = new int[2][];

    public void IterateArrayofArrays()
    {
        for (int i = 0; i < _arrayOfArrays.Length; i++)
        {
            _arrayOfArrays[i] = new int[2];
    
            for (int j = 0; j < _arrayOfArrays[i].Length; j++)
            {
                Console.WriteLine(_arrayOfArrays[i][j] + " ");
            }
        }
    }
        
    public void MultiDimensionArray()
    {
        for (int i = 0; i < _thisArrayHasTwoDimensions.GetLength(0); i++)
        {
            for (int j = 0; j < _thisArrayHasTwoDimensions.GetLength(1); j++)
            {
                Console.WriteLine(i + ", " + ": " + _thisArrayHasTwoDimensions[i, j]);
            }
        }
    }
    
    public int GetSumOfAllElements(int[][] intArrayArrays) 
    {
        int sum = 0;
        for(int i = 0; i < intArrayArrays.Length; i++ )
        {
            for (int j = 0; j < intArrayArrays[i].Length; j++)
            {
                sum += intArrayArrays[i][j];
            }
        }
        return sum;
    }
}