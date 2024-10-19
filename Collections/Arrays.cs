namespace CM_CSharp_Course.Collections;

public class Arrays
{
    int[,] thisArrayHasTwoDimensions = new int[1, 1];
    
    public void iterate2DArray()
    {
        for (int i = 0; i < thisArrayHasTwoDimensions.GetLength(0); i++)
        {
            for (int j = 0; j < thisArrayHasTwoDimensions.GetLength(1); j++)
            {
                Console.WriteLine(i + ", " + ": " + thisArrayHasTwoDimensions[i, j]);
            }
        }
    }
    
    int [][] arrayOfArrays = new int[2][];

    public void iterateArrayofArrays()
    {
        for (int i = 0; i < arrayOfArrays.Length; i++)
        {
            arrayOfArrays[i] = new int[2];
    
            for (int j = 0; j < arrayOfArrays[i].Length; j++)
            {
                Console.WriteLine(arrayOfArrays[i][j] + " ");
            }
        }
    }
    
    int[,] thisArrayHasTwoDimensionsAsWell = new int[4, 4];
        
    public void MultiDimensionArray()
    {
        for (int i = 0; i < thisArrayHasTwoDimensions.GetLength(0); i++)
        {
            for (int j = 0; j < thisArrayHasTwoDimensions.GetLength(1); j++)
            {
                Console.WriteLine(i + ", " + ": " + thisArrayHasTwoDimensions[i, j]);
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