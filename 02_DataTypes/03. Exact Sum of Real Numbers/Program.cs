//Create a program to enter n numbers and calculate and print their exact sum (without rounding).

using System;

namespace _03._Exact_Sum_of_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //V
            int number = int.Parse(Console.ReadLine());

            decimal sum = 0;
            for (int i = 0; i < number; i++)
            {
                decimal num = decimal.Parse(Console.ReadLine());
                sum += num;
            }
            Console.WriteLine(sum);
        }
    }
}
