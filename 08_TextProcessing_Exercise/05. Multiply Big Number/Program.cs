//You are given two lines – the first one can be a really big number (0 to 1050).
//The second one will be a single-digit number (0 to 9). Your task is to display the product of these numbers.
//Note: do not use the BigInteger class.

using System;
using System.Collections.Generic;
using System.Numerics;

namespace _05._Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string bigNum = Console.ReadLine();
            int multiplier = int.Parse(Console.ReadLine());

            int sum = 0;
            List<string> sumOf = new List<string>();

            for (int i = bigNum.Length - 1; i >= 0; i--)
            {
                int currentNumber = int.Parse(bigNum[i].ToString());

                sum = currentNumber * multiplier;

                if (sum > 9)
                {
                    int remainder = sum % 10;
                    sumOf.Add(remainder.ToString());
                    sum += sum / 10;
                }
                else
                {
                    sum += sum / 10;
                    sumOf.Add(sum.ToString());
                }
            }

            sumOf.Reverse();
            foreach (var item in sumOf)
            {
                Console.Write(item);
            }
        }
    }
}
