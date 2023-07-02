//You have a water tank with a capacity of 255 liters.
//On the next n lines, you will receive liters of water, which you have to pour into your tank.
//If the capacity is not enough, print "Insufficient capacity!" and continue reading the next line.
//On the last line, print the liters in the tank.
//Input
//The input will be on two lines:
//•	On the first line, you will receive n – the number of lines, which will follow
//•	On the next n lines – you receive quantities of water, which you have to pour into the tank
//Output
//Every time you do not have enough capacity in the tank to pour the given liters, print:
//Insufficient capacity!
//On the last line, print only the liters in the tank.

using System;

namespace _07._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            // // First attempt 
            // const int CAPACITY = 255;
            // int lines = int.Parse(Console.ReadLine());
            //
            // int sum = 0;
            // for (int i = 0; i < lines; i++)
            // {
            //     int curentPours = int.Parse(Console.ReadLine());
            //     sum += curentPours;
            //     while (sum > CAPACITY)
            //     {
            //         Console.WriteLine("Insufficient capacity!");
            //         sum -= curentPours;
            //         i++;
            //         if (i < lines == false)
            //         {
            //             break;
            //         }
            //         curentPours = int.Parse(Console.ReadLine());
            //         sum += curentPours;
            //     }
            // }
            // Console.WriteLine(sum);


            // Second attempt
            // Constant for the capacity 
            const int CAPACITY = 255;
            int nLines = int.Parse(Console.ReadLine());
            int totalQuantity = CAPACITY;

            for (int i = 0; i < nLines; i++)
            {
                int currQuantity = int.Parse(Console.ReadLine());
                if (totalQuantity - currQuantity >= 0)
                {
                    totalQuantity -= currQuantity;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }

            int totalFieldQuntitiy = CAPACITY - totalQuantity;
            Console.WriteLine(totalFieldQuntitiy);
        }
    }
}
