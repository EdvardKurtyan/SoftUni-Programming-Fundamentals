//Create a method that prints out the smallest of three integer numbers.

using System;

namespace _01._Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());


            int result = TakingTheSmallestInteger(firstNumber, secondNumber, thirdNumber);

            Console.WriteLine(result);
        }

        static int TakingTheSmallestInteger(int firstNumber, int secondNumber, int thirdNumber)
        {
            int[] numbers = { firstNumber, secondNumber, thirdNumber };

            Array.Sort(numbers);

            return numbers[0];
        }
    }
}
