//A top number is an integer that holds the following properties:
//•	Its sum of digits is divisible by 8, e.g. 8, 17, 88
//•	Holds at least one odd digit, e.g. 232, 707, 87578
//•	Some examples of top numbers are: 17, 161, 251, 4310, 123200
//Create a program to print all top numbers in the range [1…n].
//You will receive a single integer from the console, representing the end value. 

using System;
using System.Linq;

namespace _10._Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            PrintingTheTopNumber(input);
        }

        private static void PrintingTheTopNumber(int input)
        {
            for (int i = 1; i < input; i++)
            {
                int sum = 0;

                int curentNumber = i;
                int copyOfCurentNumber = curentNumber;

                int oddDigitsCounter = 0;
                while (curentNumber != 0)
                {
                    curentNumber %= 10;
                    copyOfCurentNumber /= 10;

                    if (curentNumber % 2 != 0)
                    {
                        oddDigitsCounter++;
                    }
                    sum += curentNumber;
                    curentNumber = copyOfCurentNumber;
                }

                if (sum % 8 == 0 && oddDigitsCounter > 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
