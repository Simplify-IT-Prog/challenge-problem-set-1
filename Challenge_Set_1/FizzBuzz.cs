using System;

namespace Challenge_Set_1
{
    class FizzBuzz
    {
        public static void Main()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.Write("FizzBuzz ");
                } else if (i % 3 == 0)
                {
                    Console.Write("Fizz ");
                } else if (i % 5 == 0)
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

// Attempt to use ternary 

            for (int i = 1; i <= 100; i++)
            {
                (i % 3 == 0 && i % 5 == 0) ? Console.Write("FizzBuzz ") : ((i % 3 == 0) ? Console.Write("Fizz ") : ( (i % 5 == 0) ? Console.Write("Buzz ") : Console.Write("{0} ", i) ) );
            }