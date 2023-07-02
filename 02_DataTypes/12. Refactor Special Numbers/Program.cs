//You are given a working code that is a solution to Problem 5. Special Numbers.
//However, the variables are improperly named, declared before they are needed and some of them are used for multiple things.
//Without using your previous solution, modify the code so that it is easy to read and understand.

using System;

namespace _12._Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //V
            int count = int.Parse(Console.ReadLine());
            for (int i = 1; i <= count; i++)
            {
                int sumOfDigits = 0;
                int digit = i;

                while (digit != 0)
                {
                    sumOfDigits += digit % 10;
                    digit = digit / 10;
                }

                if (sumOfDigits == 5 || sumOfDigits == 7 || sumOfDigits == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
            }

        }
    }
}
