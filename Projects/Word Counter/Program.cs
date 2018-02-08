// --------------------------------------------------------------------------------------------------------------------
// <summary>
//   Count Words in a String
//   Counts the number of individual words in a string.
//   For added complexity read these strings in from a text file and generate a summary.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Word_Counter
{
    using System;

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
            var delimiters = new[] { ' ', ',', '.' };
            Console.WriteLine(input?.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).Length);
        }
    }
}