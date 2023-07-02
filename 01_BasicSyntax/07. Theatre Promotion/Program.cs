//A theatre is sail tickets at discount, and a program is needed to calculate the price of a single ticket.
//If the given age does not fit one of the categories, you should print "Error!".  
//The prices of the tickers are as follows:
//Day / Age   0 <= age <= 18  18 < age <= 64  64 < age <= 122
//Weekday 12$	18$	12$
//Weekend 15$	20$	15$
//Holiday 5$	12$	10$
//Input
//The input comes in two lines. On the first line, you will receive the type of day.
//On the second – the age of the person.
//Output
//Print the price of the ticket according to the table, or "Error!" if the age is not in the table.

using System;

namespace _07TheatrePromotion
{
    class Program
    {
        static void Main()
        {
            //V
            //            Day / Age   0 <= age <= 18 | 18 < age <= 64 | 64 < age <= 122
            //             Weekday          12$	     |      18$	      |      12$
            //             Weekend          15$	     |      20$	      |      15$
            //             Holiday          5$	     |      12$	      |      10$

            string day = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            if (age < 0 || age > 122)
            {
                Console.WriteLine("Error!");
            }
            else if (age >= 0)
            {
                switch (day)
                {
                    case "Weekday":
                        if (age >= 0 && age <= 18 || age > 64 && age <= 122)
                        {
                            Console.WriteLine("12$");
                        }
                        else if (age > 18 && age <= 64)
                        {
                            Console.WriteLine("18$");
                        }
                        break;
                    case "Weekend":
                        if (age >= 0 && age <= 18 || age > 64 && age <= 122)
                        {
                            Console.WriteLine("15$");
                        }
                        else if (age > 18 && age <= 64)
                        {
                            Console.WriteLine("20$");
                        }
                        break;
                    case "Holiday":
                        if (age >= 0 && age <= 18)
                        {
                            Console.WriteLine("5$");
                        }
                        else if (age > 18 && age <= 64)
                        {
                            Console.WriteLine("12$");
                        }
                        else if (age > 64 && age <= 122)
                        {
                            Console.WriteLine("10$");
                        }
                        break;
                }
            }


        }
    }
}
