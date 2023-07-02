//Create a program to enter an integer number of centuries and convert it to years, days, hours, and minutes.

using System;

namespace _04._Centuries_to_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            //V
            int centuries = int.Parse(Console.ReadLine());

            int years = centuries * 100;

            double days = (int)(years * 365.2422);

            double hours = (int)(days * 24);
            
            double minutes = hours * 60;
            
            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
        }
    }
}
