//Read a number n and n lines of products. Print a numbered list of all the products ordered by name.

using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_of_Products
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<string> products = new List<string>();   

            for (int i = 0; i < count; i++)
            {
                products.Add(Console.ReadLine());
            }

            products.Sort();

            int counter = 1;
            foreach (var curentProduct in products)
            {
                Console.WriteLine($"{counter}.{curentProduct}");
                counter++;
            }
        }
    }
}
