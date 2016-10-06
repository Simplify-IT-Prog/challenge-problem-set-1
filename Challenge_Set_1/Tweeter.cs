/**
This lazy tweeter/travel-blogger shouldn't like naps, they should like maps!

Change the output of tweeter() so that whenever someone writes "naps" the output replaces it with "maps".

Implement twice, once with String.IndexOf, another with Regular expressions
**/

using System;

public class Program
{
    static string tweeter(string text)
    {
        // YOUR CODE 
        while (text.IndexOf("naps") >= 0)
        {
            int indexPos = text.IndexOf("naps");
            text = text.Remove(indexPos, 4);
            text = text.Insert(indexPos, "maps");
        }
        return text;
    }
    public static void Main()
    {
        Console.WriteLine(tweeter("I really like naps") == "I really like maps");
        Console.WriteLine(tweeter("naps maps naps maps") == "maps maps maps maps");
    }
}

// Using Regular Expression
using System;
using System.Text.RegularExpressions;

public class Program
{
    static string tweeter(string text)
    {
        // YOUR CODE USING REGEX
        Console.WriteLine(text);
        string pattern = "\bnaps\";
        string replacement = "maps";
        Regex regExpression = new Regex(pattern);
        text = regExpression.Replace(text, replacement);
        Console.WriteLine(text);
        return text;
    }
    public static void Main()
    {
        Console.WriteLine(tweeter("I really like naps") == "I really like maps");
        Console.WriteLine(tweeter("naps maps naps maps") == "maps maps maps maps");
    }
}



