//Define a class Item, which contains these properties: Name and Price.
//Define a class Box, which contains these properties: Serial Number, Item, Item Quantity and Price for a Box.
//Until you receive "end", you will be receiving data in the following format: "{Serial Number} {Item Name} {Item Quantity} {itemPrice}"
//The Price of one box has to be calculated: itemQuantity* itemPrice.
//Print all the boxes ordered descending by price for a box, in the following format: 
//{ boxSerialNumber}
//-- { boxItemName} – ${ boxItemPrice}: { boxItemQuantity}
//-- ${ boxPrice}
//The price should be formatted to the 2nd digit after the decimal separator.

using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Store_Boxes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Item> allItems = new List<Item>();
            List<Box> allBoxes = new List<Box>();

            while (true)
            {
                string[] input = Console.ReadLine().Split();
                string command = input[0];
                if (command == "end") break;
                Box box = new Box
                {
                    SerialNumber = input[0],

                    Item = new Item
                    {
                        Name = input[1],
                        Price = decimal.Parse(input[3])
                    },
                    ItemQuantity = int.Parse(input[2])
                };
                allBoxes.Add(box);
            }

            List<Box> sortedBoxes = allBoxes.OrderByDescending(box => box.BoxPrice).ToList();

            foreach  (var curentBox in sortedBoxes)
            {
                Console.WriteLine(curentBox.SerialNumber);
                Console.WriteLine($"-- {curentBox.Item.Name} - ${curentBox.Item.Price:f2}: {curentBox.ItemQuantity}");
                Console.WriteLine($"-- ${curentBox.BoxPrice:f2}");
            }
        }
    }
    class Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
    class Box
    {
        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public decimal BoxPrice
        {
            get
            {
                return ItemQuantity * Item.Price;
            }
        }
    }
}
