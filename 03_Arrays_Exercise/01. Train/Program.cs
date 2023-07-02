//A train has an **n** number of wagons (integer, received as input).
//On the next n lines, you will receive the number of people that are going to get on each wagon.
//Print out the number of passengers in each wagon followed by the total number of passengers on the train.

using System;
using System.Linq;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            //V
            int wagons = int.Parse(Console.ReadLine());
            int[] peoplePerWagon = new int[wagons];

            int sum = 0;
            for (int i = 0; i < wagons; i++)
            {
                peoplePerWagon[i] = int.Parse(Console.ReadLine());
                sum += peoplePerWagon[i];
            }

            foreach (var curentWagon in peoplePerWagon)
            {
                Console.Write($"{curentWagon} ");
            }

            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}
