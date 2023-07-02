//Read two integers. Calculate the factorial of each number.
//Divide the first result by the second and print the result of the division formatted to the second decimal point.

using System;

namespace _00._Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal firstNumber = decimal.Parse(Console.ReadLine());
            decimal secondNumber = decimal.Parse(Console.ReadLine());

            decimal firstFactorial = Factorial(firstNumber);
            decimal secondFactorial = Factorial(secondNumber);

            decimal result = DevidetFactorials(firstFactorial, secondFactorial);

            Console.WriteLine($"{result:F2}");
        }

        private static decimal Factorial(decimal firstNumber)
        {
            decimal sum = 1;
            for (decimal i = 1; i <= firstNumber; i++)
            {
                sum *= i;
            }
            return sum;
        }
        private static decimal DevidetFactorials(decimal firstFactorial, decimal secondFactorial) => firstFactorial / secondFactorial;
    }
}
