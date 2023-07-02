//Create a method, which receives two numbers as parameters:
//•	The first number – the base
//•	The second number – the power
// The method should return the base rase to the given power.

using System;

namespace _08._Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double powerNumber = double.Parse(Console.ReadLine());

            Console.WriteLine(PoweredResult(number, powerNumber));
        }

        private static double PoweredResult(double number,double powerNumber)
        {
            double result = Math.Pow(number, powerNumber);
            return result;
        }
    }
}
