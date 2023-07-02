//Create a program that prints whether a given character is upper-case or lower case.

using System;

namespace _10._Lower_or_Upper
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter = char.Parse(Console.ReadLine());
            bool result = char.IsUpper(letter);

            if (result == true)
            {
                Console.WriteLine("upper-case");
            }
            if (result == false)
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}
