//Write a method that receives two numbers and an operator, calculates the result, and returns it.
//You will be given three lines of input. The first will be the first number,
//the second one will be the operator and the last one will be the second number.
//The possible operators are: /, *, +and -.

using System;

namespace _11._Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = int.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            double secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(Calculate(firstNumber, @operator, secondNumber));
        }

        static double Calculate(double numOne, string @operator, double numTwo)
        {
            double result = 0;
            switch (@operator)
            {
                case "+":
                    result = numOne + numTwo;
                    break;
                case "-":
                    result = numOne - numTwo;
                    break;
                case "*":
                    result = numOne * numTwo;
                    break;
                case "/":
                    result = numOne / numTwo;
                    break;
            }
            return result;
        }
    }
}
