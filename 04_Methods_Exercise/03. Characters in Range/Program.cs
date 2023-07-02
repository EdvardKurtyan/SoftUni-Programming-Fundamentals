//Create a method that receives two characters and prints all the characters between them according to ASCII (on a single line).
//NOTE: If the second letter's ASCII value is less than that of the first one then the two initial letters should be swapped.

using System;

namespace _03._Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char startChar = char.Parse(Console.ReadLine());
            char endChar = char.Parse(Console.ReadLine());

            PrintingTheResult(startChar, endChar);
        }

        private static void PrintingTheResult(char startChar, char endChar)
        {

            for (int i = Math.Min(startChar, endChar) + 1; i < Math.Max(startChar, endChar); i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}
