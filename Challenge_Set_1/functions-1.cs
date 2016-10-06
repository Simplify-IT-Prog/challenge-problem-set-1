/**
Something's wrong with the below function! Refactor it to make the code work as expected.
**/

using System;

public class functions1
{
    // static Func<int, int, int> sum = (a, b) => a + b;

    static int sum_old (int a, int b)
    {
        return ( a + b);
    }
    public static void Main()
    {
        Console.WriteLine(sum_old(1, 2) == 3);
    }
}

/**
Part 2: re-write sum as a lambda or Func<int, int, int>
    static Func<int, int, int> sum = (a, b) => a + b;
**/


