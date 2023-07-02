//Write a program that determines if a person is baby, child, teenager, adult, elder based on the given age. The bounders are:
//•	0 - 2 – baby
//•	3 - 13 – child
//•	14 - 19 – teenager
//•	20 - 65 – adult
//•	>= 66 – elder
//•	All the values are inclusive.

using System;

namespace _01._Ages
{
    class Program
    {
        static void Main(string[] args)
        {
            //V
            // 0-2 – baby
            // 3 - 13 – child
            // 14 - 19 – teenager
            // 20 - 65 – adult
            // >= 66 – elder

            int age = int.Parse(Console.ReadLine());

            string result = age <= 2 ? "baby" :
                age >= 3 && age <= 13 ? "child" :
                age >= 14 && age <= 19 ? "teenager" :
                age >= 20 && age <= 65 ? "adult" : "elder";

            Console.WriteLine(result);
        }
    }
}
