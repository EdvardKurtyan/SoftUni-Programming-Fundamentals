//Write a program that accumulates coins.
//Until the "Start" command is given, you will receive coins, and only the valid ones should be accumulated. Valid coins are:
//•	0.1, 0.2, 0.5, 1, and 2
//If an invalid coin is inserted, print "Cannot accept {money}" and continue to the next line.
//On the next lines, until the "End" command is given you will start receiving products, which a customer wants to buy.
//The vending machine has only:
//•	"Nuts" with a price of 2.0
//•	"Water" with a price of 0.7
//•	"Crisps" with a price of 1.5
//•	"Soda" with a price of 0.8
//•	"Coke" with a price of 1.0
//If the customer tries to purchase a not existing product print "Invalid product".
//When a customer has enough money to buy the selected product, print "Purchased {product name}",
//otherwise print "Sorry, not enough money", and continue to the next line.
//When the "End" command is given print the reminding balance, formatted to the second decimal point: "Change: {money left}".


using System;

namespace _07._Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            //V
            // "Nuts" - 2.0
            // "Water" - 0.7
            // "Crisps" - 1.5
            // "Soda" - 0.8
            // "Coke" - 1.0

            string comand = Console.ReadLine();
            double sum = 0;

            while (comand != "Start")
            {
                double inputMoney = double.Parse(comand);
                if (inputMoney == 0.1 || inputMoney == 0.2 || inputMoney == 0.5 || inputMoney == 1.00 || inputMoney == 2.00)
                {
                    sum += inputMoney;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {inputMoney}");
                }
                comand = Console.ReadLine();
            }
            double price = 0;
            double sumOfPrice = 0;
            comand = Console.ReadLine();
            while (comand != "End")
            {
                switch (comand)
                {
                    case "Nuts":
                        price = 2;
                        break;
                    case "Water":
                        price = 0.7;
                        break;
                    case "Crisps":
                        price = 1.5;
                        break;
                    case "Soda":
                        price = 0.8;
                        break;
                    case "Coke":
                        price = 1;
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        comand = Console.ReadLine();
                        continue;
                        //break;
                }
                if (sum >= sumOfPrice && sum >= price)
                {
                    sumOfPrice += price;
                    Console.WriteLine($"Purchased {comand.ToLower()}");
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }
                comand = Console.ReadLine();
            }
            sum -= sumOfPrice;
            Console.WriteLine($"Change: {Math.Abs(sum):F2}");

        }
    }
}
