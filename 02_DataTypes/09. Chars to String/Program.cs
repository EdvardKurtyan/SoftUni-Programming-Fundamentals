//Create a program that reads 3 lines of input. On each line, you get a single character.
//Combine all the characters into one string and print it on the console.

using System;

namespace _09._Chars_to_String
{
    class Program
    {
        static void Main(string[] args)
        {
            //V
            char firstCharacter = char.Parse(Console.ReadLine());
            char secondCharacter = char.Parse(Console.ReadLine());
            char thirdCharacter = char.Parse(Console.ReadLine());

            Console.WriteLine($"{firstCharacter}{secondCharacter}{thirdCharacter}");
        }
    }
}
