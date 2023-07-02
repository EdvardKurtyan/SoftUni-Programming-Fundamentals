//Create a program that keeps the information about products and their prices. Each product has a name, a price and a quantity.
//If the product doesn't exist yet, add it with its starting quantity.
//If you receive a product, which already exists, increase its quantity by the input quantity and if its price is different, replace the price as well.
//You will receive products' names, prices and quantities on new lines. Until you receive the command "buy", keep adding items.
//When you do receive the command "buy", print the items with their names and the total price of all the products with that name.
//Input
//•	Until you receive "buy", the products will be coming in the format: "{name} {price} {quantity}".
//•	The product data is always delimited by a single space.
//Output
//•	Print information about each product in the following format: 
//"{productName} -> {totalPrice}"
//•	Format the average grade to the 2nd digit after the decimal separator.

using System;
using System.Collections.Generic;

namespace _03._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = new Dictionary<string, double>();
            var productsQuantity = new Dictionary<string, int>();

            while (true)
            {
                string[] input = Console.ReadLine().Split();
                string command = input[0];
                if (command == "buy") break;
                string product = input[0];
                double price = double.Parse(input[1]);
                int quantity = int.Parse(input[2]);

                if (!products.ContainsKey(product))
                {
                    products.Add(product, price);
                    productsQuantity.Add(product, quantity);
                }
                else if (products.ContainsKey(product))
                {
                    products.Remove(product);
                    products.Add(product, price);
                    productsQuantity[product] += quantity;
                }
            }
            foreach (var product in products)
            {
                foreach (var item in productsQuantity)
                {
                    if (product.Key == item.Key)
                    {
                        Console.WriteLine($"{product.Key} -> {product.Value * item.Value:f2}");
                    }
                }
            }
        }
    }
}
