using System.Runtime.InteropServices;
using CM_CSharp_Course.Classes;

namespace CM_CSharp_Course.Operators;

public class SizeOf
{
    public void SizeOfMainMethod()
    {
        int i = 5;
        Console.WriteLine(sizeof(int));
        Console.WriteLine(sizeof(double));
        Console.WriteLine(sizeof(float));

        // Console.WriteLine(Marshal.SizeOf(new Player())); // this throws and error unless you have [StructLayout(LayoutKind.Sequential)] on your 'Player' class
    }
}