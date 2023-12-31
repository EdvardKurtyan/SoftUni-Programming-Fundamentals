﻿//As a MOBA challenger player, Petar has the bad habit to trash his PC when he loses a game and rage quits.
//His gaming setup consists of a headset, mouse, keyboard, and display. You will receive Petar's lost games count. 
//Every second lost game, Petar trashes his headset.
//Every third lost game, Petar trashes his mouse.
//When Petar trashes both his mouse and headset in the same lost game, he also trashes his keyboard.
//Every second time, when he trashes his keyboard, he also trashes his display. 
//You will receive the price of each item in his gaming setup.
//Calculate his rage expenses for renewing his gaming equipment. 
//Input / Constraints
//•	On the first input line - lost games count – integer in the range [0, 1000].
//•	On the second line – headset price - the floating-point number in the range [0, 1000]. 
//•	On the third line – mouse price - the floating-point number in the range [0, 1000]. 
//•	On the fourth line – keyboard price - the floating-point number in the range [0, 1000]. 
//•	On the fifth line – display price - the floating-point number in the range [0, 1000]. 
//Output
//•	As output you must print Petar's total expenses: "Rage expenses: {expenses} lv."

using System;

namespace _10._Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            // V
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double fullPrice = 0;
            int keyboardBreaksCounter = 0;
            for (int i = 1; i < lostGames; i++)
            {
                // When he breaks his headset.
                if (i % 2 == 0)
                {
                    fullPrice += headsetPrice;
                }
                // When he break his mouse.
                if (i % 3 == 0)
                {
                    fullPrice += mousePrice;
                }
                // When he broke his headset and mouse at the same time.
                if (i % 6 == 0)
                {
                    keyboardBreaksCounter++;
                    fullPrice += keyboardPrice;

                    // When he break his display.
                    if (keyboardBreaksCounter % 2 == 0)
                    {
                        fullPrice += displayPrice;
                    }
                }

            }
            //•	As output you must print Petar's total expenses: "Rage expenses: {expenses} lv.".
            Console.WriteLine($"Rage expenses: {fullPrice:f2} lv.");
        }
    }
}

