// --------------------------------------------------------------------------------------------------------------------
// <summary>
//   Fizz Buzz
//   Write a program that prints the numbers from 1 to 100. 
//   But for multiples of three print “Fizz” instead of the number and for the multiples of five print “Buzz”. 
//   For numbers which are multiples of both three and five print “FizzBuzz”.
// </summary>
// 
// --------------------------------------------------------------------------------------------------------------------

namespace FizzBuzz
{
    using System;

    /// <summary>
    /// The program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The main.
        /// </summary>
        private static void Main()
        {
            for (var i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write(i % 5 == 0 ? " Fizz-Buzz " : " Fizz ");
                }
                else
                {
                    if (i % 5 == 0)
                    {
                        Console.Write(" Buzz ");
                    }
                    else
                    {
                        Console.Write(" " + i + " ");
                    }
                }
            }
        }
    }
}
