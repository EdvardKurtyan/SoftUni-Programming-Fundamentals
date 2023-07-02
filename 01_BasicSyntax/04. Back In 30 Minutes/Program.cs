//Every time John tries to pay the bills he sees on the cash desk the sign: "I will be back in 30 minutes".
//One day John was tired of waiting and decided he needs a program, which prints the time after 30 minutes,
//so could come back after exactly 30 minutes.
//He is not able to write the program by himself, so he asks for help. 
//Input
//Two numbers are read from the console:
//•	The first number is hours and will be between 0 and 23.
//•	The second number is minutes and will be between 0 and 59.
//Output
//Print on the console the time after 30 minutes.
//The result should be in format hh:mm.
//The hours may contain one or two numbers and the minutes always have two numbers (with leading zero).

using System;

namespace _04BackIn30Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            //V
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            minutes += 30;

            if (minutes > 59)
            {
                minutes -= 60;
                hours++;
            }
            if (hours >= 23)
            {
                hours -= 24;
            }

            Console.WriteLine($"{hours}:{minutes:D2}");
        }
    }
}
