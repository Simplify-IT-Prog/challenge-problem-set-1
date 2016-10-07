using System;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace Challenge_Set_1
{
    class Challenges
    {
        public static void Main()
        {
            // Vector Magnitude (distance between two points)
            Debug.Assert(vectorLength(new float[2, 2] { { 0, 3 }, { 4, 0 } }) == 5);
            Debug.Assert(vectorLength(new float[2, 2] { { 1, -1 }, { 1, -1 } }) == 0);
            Debug.Assert(vectorLength(new float[2, 2] { { 0, 1 }, { 0, 0 } }) == 1);

            // Calculate distance between two point using delegates (lambdas)
            Debug.Assert(magnitude_lambda(new float[2, 2] { { 0, 1 }, { 0, 0 } }) == 1);
            
            // functions-1: Returns the sum of two integers using traditional static functions
            Debug.Assert(sum_traditional(1, 2) == 3);

            // functions-1: Returns the sum of two integers using delegates (lambdas)
            Debug.Assert(sum_lambda(1, 2) == 3);

            // Scaling Random Numbers
            Debug.Assert(random(1, 2) <= 2 && random(1, 2) >= 1);
            Debug.Assert(random(-11, 22) <= 22 && random(-11, 22) >= -11);

            // Scaling Random Numbers using delegates (lambdas)
            Debug.Assert(random_lambda(-11, 22) <= 22 && random_lambda(-11, 22) >= -11);

            // Tweeter: universal text replace: send String, the search string and the replacement string
            Debug.Assert(tweeter("I really like naps", "naps", "maps") == "I really like maps");
            Debug.Assert(tweeter("naps maps naps maps", "naps", "maps") == "maps maps maps maps");

            // FizzBuss: lists integers from 1 to 100.  Replaces two integers with FizzBuzz
            writeFizzBuzz( 3, 5);

            // Test SomeEvilProgram: demonstrate scope and access modifiers
            SomeEvilProgram.testRun();

            Console.ReadLine();
        }

        //Calculates distance between two points passed as an array[2,2]
        static float vectorLength(float[,] vecs)
        {
            return (float)Math.Sqrt(Math.Pow(vecs[0, 0] - vecs[1, 0], 2) + Math.Pow(vecs[0, 1] - vecs[1, 1], 2));
        }
        static float magnitude_lambda (float[,] vecs) => (float)Math.Sqrt(Math.Pow(vecs[0, 0] - vecs[1, 0], 2) + Math.Pow(vecs[0, 1] - vecs[1, 1], 2));
        
        //Calculate sum of two integers
        static int sum_traditional(int a, int b)
        {
            return (a + b);
        }
        static Func<int, int, int> sum_lambda = (a, b) => a + b;

        //Generates random integer between int min and int max.
        static int random(int min, int max)
        {
            Random rnd = new Random();
            return (int)(rnd.NextDouble() * (max - min) + min);
        }
        static int random_lambda(int min, int max) => (int)(new Random().NextDouble() * (max - min) + min);

        //For any given string text, tweeter replaces the textSearch with the textReplace.
        static string tweeter(string text, string textSearch, string textReplace)
        {
            while (text.IndexOf(textSearch) >= 0)
            {
                int indexPos = text.IndexOf(textSearch);
                text = text.Remove(indexPos, 4).Insert(indexPos, textReplace);
            }
            return text;
        }

        static void writeFizzBuzz(int num1, int num2)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % num1 == 0 && i % num2 == 0)
                {
                    Console.Write("FizzBuzz ");
                } else if (i % num1 == 0)
                {
                    Console.Write("Fizz ");
                } else if (i % num2 == 0)
                {
                    Console.Write("Buzz ");
                } else
                {
                    Console.Write("{0} ", i);
                }       
            }
        }
    }
}
