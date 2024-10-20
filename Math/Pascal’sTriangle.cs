namespace CM_CSharp_Course.Math;

public class PascalSTriangle
{
    public static List<List<long>> GeneratePascalsTriangle(int n)
    {
        List<List<long>> triangle = new List<List<long>>();

        for (int i = 0; i < n; i++)
        {
            List<long> row = new List<long>();
            for (int j = 0; j <= i; j++)
            {
                if (j == 0 || j == i)
                    row.Add(1);
                else
                    row.Add(triangle[i - 1][j - 1] + triangle[i - 1][j]);
            }
            triangle.Add(row);
        }

        return triangle;
    }
    
    public static void CallingToPrintExample(string[] args)
    {
        var triangle = GeneratePascalsTriangle(5);

        // Display the triangle
        foreach (var row in triangle)
        {
            foreach (var number in row)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }

        // Keep the console window open
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}