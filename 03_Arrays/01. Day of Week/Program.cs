//Enter a number in range 1-7 and print out the word representing it or "Invalid Day!". Use an array of strings.

using System;

namespace _01._Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            //V
            int numberOfDay = int.Parse(Console.ReadLine());
            string[] day = 
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            if (numberOfDay >= 1 && numberOfDay <= 7)
            {
                Console.WriteLine(day[numberOfDay - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
