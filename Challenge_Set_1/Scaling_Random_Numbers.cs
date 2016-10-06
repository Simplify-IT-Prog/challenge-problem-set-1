/**
Write a function random(a,b) that returns a random integer between a and b.

Use Random.nextDouble(), not Random.next()
**/

using System;
using System.Diagnostics;

public class Program
{
    static double random(int min, int max)
    {
        // YOUR CODE 
        Random rnd = new Random();
        return rnd.NextDouble()*(max-min)+min;
    }
    public static void Main()
    {
        Console.WriteLine(random(1, 2) <= 2 && random(1, 2) >= 1);
        Console.WriteLine(random(-11, 22) <= 22 && random(-11, 22) >= -11);
    }
}
