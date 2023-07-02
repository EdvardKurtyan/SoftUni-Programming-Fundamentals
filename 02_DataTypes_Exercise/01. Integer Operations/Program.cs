//Create a program that receives four integer numbers.
//You should perform the following operations:
//•	Add first to the second.
//•	Divide (integer) the result of the first operation by the third number.
//•	Multiply the result of the second operation by the fourth number. 
//Print the result after the last operation.

using System;

namespace _01._Integer_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            //V
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int divideNumber = int.Parse(Console.ReadLine());
            int multiplyNumber = int.Parse(Console.ReadLine());

            int result = (firstNumber + secondNumber) / divideNumber * multiplyNumber;

            Console.WriteLine(result);
        }
    }
}
