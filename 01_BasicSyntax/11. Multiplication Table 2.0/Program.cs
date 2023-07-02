//Rewrite the program from the previous task so it can receive the multiplier from the console.
//Print the table from the given multiplier to 10. If the given multiplier is more than 10 -
//print only one row with the integer, the given multiplier, and the product.

using System;

namespace _11MultiplicationTable2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            //V
            int input = int.Parse(Console.ReadLine());
            int stratingNum = int.Parse(Console.ReadLine());

            if (stratingNum > 10)
            {
                Console.WriteLine($"{input} X {stratingNum} = {input * stratingNum}");
                return;
            }

            for (int i = stratingNum; i <= 10; i++)
            {
                Console.WriteLine($"{input} X {i} = {input * i}");
            }
        }
    }
}
