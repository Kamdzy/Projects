// --------------------------------------------------------------------------------------------------------------------
// <summary>
//   Check if Palindrome
//   Checks if the string entered by the user is a palindrome.
//   That is that it reads the same forwards as backwards like “racecar”
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Palindrome_Checker
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
            Console.WriteLine(output.Equals(input) ? "The text is a palindrome" : "The text is not a palindrome");
        }
    }
}