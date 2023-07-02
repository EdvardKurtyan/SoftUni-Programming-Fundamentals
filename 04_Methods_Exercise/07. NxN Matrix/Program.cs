//Create a method that receives a single integer n and prints an NxN matrix using this number as a filler.

using System;

namespace _07._NxN_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            Matrix(num);
        }

        private static void Matrix(int num)
        {
            for (int i = 0; i < num; i++)
            {
                for (int u = 0; u < num; u++)
                {
                    Console.Write(num + " ");
                }
                    Console.WriteLine();
            }
        }
    }
}
