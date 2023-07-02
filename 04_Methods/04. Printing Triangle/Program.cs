//Create a method for printing triangles as shown below:

using System;

namespace _04._Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            UpperPartOfPiramide(lines);
            BottomPartOfPiramide(lines);
        }
        private static void UpperPartOfPiramide(int lines)
        {
            for (int i = 1; i <= lines; i++)
            {
                for (int r = 1; r <= i; r++)
                {
                    Console.Write(r + " ");
                }
                Console.WriteLine();
            }
        }
        private static void BottomPartOfPiramide(int lines)
        {
            for (int i = lines - 1; i > 0; i--)
            {
                for (int t = 1; t <= i; t++)
                {
                    Console.Write(t + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
