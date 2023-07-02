//Read n numbers and print them in reverse order, separated by a single space.

using System;

namespace _02._Print_Numbers_in_Reverse_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            //V
            int length = int.Parse(Console.ReadLine());

            int[] numbers = new int[length];

            for (int i = numbers.Length -1; i >= 0; i--)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            for (int f = 0; f < numbers.Length; f++)
            {
                Console.Write($"{numbers[f]} ");
            }
        }
    }
}
