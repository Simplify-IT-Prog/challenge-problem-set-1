/**
For a given 2D vector described by cartesian coordinates of its initial point 
and terminal point in the following format: [[x1, y1], [x2, y2]], your function 
must return this vector's length presented as a float.
**/

using System;

public class Program
{
    static float vectorLength(float[,] vecs)
    {
        return (float) Math.Sqrt(Math.Pow(vecs[0, 0] - vecs[1, 0], 2) + Math.Pow(vecs[0, 1] - vecs[1, 1], 2));
    }
    public static void Main()
    {
        Console.WriteLine(vectorLength(new float[2, 2] { { 0, 3 }, { 4, 0 } }) == 5);
        Console.WriteLine(vectorLength(new float[2, 2] { { 1, -1 }, { 1, -1 } }) == 0);
        Console.WriteLine(vectorLength(new float[2, 2] { { 0, 1 }, { 0, 0 } }) == 1);

        Console.ReadLine();
    }
}
