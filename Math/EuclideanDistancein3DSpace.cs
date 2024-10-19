namespace CM_CSharp_Course.Math;

public class EuclideanDistancein3DSpace
{
    //Calculates the distance between two points in 3D.
    public static double Distance3D(double x1, double y1, double z1, double x2, double y2, double z2)
    {
        double deltaX = x2 - x1;
        double deltaY = y2 - y1;
        double deltaZ = z2 - z1;
        return System.Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);
    }
    
    double distance3D = Distance3D(0, 0, 0, 3, 4, 12); // 13
}