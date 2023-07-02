//You will receive three lines from the console:
//•	A count of people, which are going on vacation.
//•	Type of the group (Students, Business, or Regular).
//•	 The day of the week which the group will stay (Friday, Saturday, or Sunday).
//Based on the given information calculate how much the group will pay for the entire vacation. 
//The price for a single person is as follows:
//	Friday Saturday	Sunday
//Students	8.45	9.80	10.46
//Business	10.90	15.60	16
//Regular	15	20	22.50
//There are also discounts based on some conditions:
//•	For Students, if the group is 30 or more people, you should reduce the total price by 15%
//•	For Business, if the group is 100 or more people, 10 of the people stay for free.
//•	For Regular, if the group is between 10 and 20  people (both inclusively), reduce the total price by 5%
//Note: You should reduce the prices in that EXACT order!
//As an output print the final price which the group is going to pay in the format: 
//"Total price: {price}"
//The price should be formatted to the second decimal point.

using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            //V
            //             Friday     Saturday    Sunday
            // Students     8.45        9.80       10.46
            // Business     10.90       15.60      16
            // Regular      15          20         22.50

            int people = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();

            double price = 0;
            switch (type)
            {
                case "Students":
                    switch (dayOfWeek)
                    {
                        case "Friday":
                            price = 8.45;
                            break;
                        case "Saturday":
                            price = 9.80;
                            break;
                        case "Sunday":
                            price = 10.46;
                            break;
                    }
                    if (people >= 30)
                    {
                        price *= people;
                        price = price - price * 0.15;
                    }
                    else
                    {
                        price *= people;
                    }
                    break;
                case "Business":
                    switch (dayOfWeek)
                    {
                        case "Friday":
                            price = 10.90;
                            break;
                        case "Saturday":
                            price = 15.60;
                            break;
                        case "Sunday":
                            price = 16;
                            break;
                    }
                    if (people >= 100)
                    {
                        people -= 10;
                        price *= people;
                    }
                    else
                    {
                        price *= people;
                    }
                    break;
                case "Regular":
                    switch (dayOfWeek)
                    {
                        case "Friday":
                            price = 15;
                            break;
                        case "Saturday":
                            price = 20;
                            break;
                        case "Sunday":
                            price = 22.50;
                            break;
                    }
                    if (people >= 10 && people <= 20)
                    {
                        price *= people;
                        price = price - price * 0.05;
                    }
                    else
                    {
                        price *= people;
                    }
                    break;
            }
            Console.WriteLine($"Total price: {price:f2}");
        }
    }
}
