//Create a program that receives an integer n
//and print all triples of the first n small Latin letters, ordered alphabetically:

using System;

namespace _06._Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            //V
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                char firstChar = (char)('a' + i);
                for (int y = 0; y < num; y++)
                {
                    char secondChar = (char)('a' + y);
                    for (int t = 0; t < num; t++)
                    {
                        char thirdChar = (char)('a' + t);
                        Console.Write(firstChar);
                        Console.Write(secondChar);
                        Console.Write(thirdChar);
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
