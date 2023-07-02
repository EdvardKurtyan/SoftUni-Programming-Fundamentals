//Write a program that receives a single integer and calculates is it a strong or not.
//A number is strong if the sum of the Factorial of each digit is equal to the number. 
//Example: 145 is a strong number, because 1! + 4! + 5! = 145.
//Print "yes" if the number is strong or "no" if the number is not strong.

using System;

namespace _06._Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            //V
            int num = int.Parse(Console.ReadLine());
            int numCopy = num;

            int allSumed = 0;
            int sum = 1;
            while (num > 0)
            {
                int factorial = 1;
                int curentNum = num % 10;
                num /= 10;
                sum = 1;
                for (int i = factorial; i <= curentNum; i++)
                {
                    sum = sum * i;
                }
                allSumed += sum;
                curentNum = num;
            }

            Console.WriteLine(numCopy == allSumed ? "yes" : "no");
        }
    }
}
