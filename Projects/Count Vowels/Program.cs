// --------------------------------------------------------------------------------------------------------------------
// <summary>
//   Count Vowels
//   Enter a string and the program counts the number of vowels in the text.
//   For added complexity have it report a sum of each vowel found.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Count_Vowels
{
    using System;

    /// <summary>
    ///     The program.
    /// </summary>
    internal class Program
    {
        /// <summary>
        ///     The main.
        /// </summary>
        private static void Main()
        {
            var input = Console.ReadLine();
            var arr = input?.ToCharArray();

            var counterA = 0;
            var counterE = 0;
            var counterI = 0;
            var counterO = 0;
            var counterU = 0;

            if (arr == null)
            {
                return;
            }

            foreach (var letter in arr)
            {
                switch (letter)
                {
                    case 'a':
                        counterA++;
                        break;
                    case 'e':
                        counterE++;
                        break;
                    case 'i':
                        counterI++;
                        break;
                    case 'o':
                        counterO++;
                        break;
                    case 'u':
                        counterU++;
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine(
                "Vowels amount:" + "\nA: " + counterA + "\nE: " + counterE + "\nI: " + counterI + "\nO: " + counterO
                + "\nU: " + counterU);
        }
    }
}