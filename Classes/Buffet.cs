using System;
using System.Collections.Generic;
using IronNinja.Interfaces;

namespace IronNinja.Classes
{
    class Buffet
    {
        List<IConsumable> Menu;
        public Buffet()
        {
            Menu = new List<IConsumable>()
            {
                new Drink("Sierra Mist", 300, false, true),
                new Drink("Cherry Soda", 190, false, true),
                new Drink("Fanta", 220, false, true),
                new Drink("Sierra Mist", 180, false, true),
                new Drink("Cherry Soda", 190, false, true),
                new Drink("Horchata", 250, false, true),
                new Drink("Orange Juice", 250, false, true),
                new Drink("Mango Juice", 170, false, true),
                new Drink("Candy Soda", 190, false, true),
                new Drink("Lime ", 250, false, true),
            };
        }

        public IConsumable Serve()
        {
            Random rand = new Random();
            int randConsumable = rand.Next(0, 9);
            Console.WriteLine($"Menu {Menu[randConsumable]}");
            return Menu[randConsumable];
        }
    }
}