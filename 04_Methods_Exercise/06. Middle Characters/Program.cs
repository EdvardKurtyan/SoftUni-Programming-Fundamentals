//You will receive a single string.
//Create a method that prints the character found at its middle.
//If the length of the string is even there are two middle characters.

using System;
using System.Linq;

namespace _06._Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            MiddleCharacter(text);
        }

        private static void MiddleCharacter(string text)
        {
            if (text.Length % 2 != 0)
            {
                Console.Write(text[text.Length / 2]);
            }
            else
            {
                Console.Write(text[text.Length / 2 - 1]);
                Console.Write(text[text.Length / 2]);
            }
        }
    }
}
