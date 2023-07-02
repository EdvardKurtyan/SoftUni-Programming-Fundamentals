//Create a program that takes 3 lines of characters and prints them in reversed order with a space between them.

using System;

namespace _06._Reversed_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            //V
            char firstLetter = char.Parse(Console.ReadLine());
            char secondLetter = char.Parse(Console.ReadLine());
            char thirdLetter = char.Parse(Console.ReadLine());

            Console.Write($"{thirdLetter} {secondLetter} {firstLetter}");
        }
    }
}
