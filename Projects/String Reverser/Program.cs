// --------------------------------------------------------------------------------------------------------------------
// <summary>
//   Reverse a String
//   Enter a string and the program will reverse it and print it out.
// </summary>
// 
// --------------------------------------------------------------------------------------------------------------------

namespace String_Reverser
{
    using System;
    using System.Linq;

    /// <summary>
    /// The program.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// The main.
        /// </summary>
        private static void Main()
        {
            var input = Console.ReadLine();
            var output = new string(input?.ToCharArray().Reverse().ToArray());
            Console.WriteLine(output);
        }
    }
}
