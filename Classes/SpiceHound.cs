using System;
using IronNinja.Interfaces;

namespace IronNinja.Classes
{
    class SpiceHound : Ninja
    {
        public override void Consume (IConsumable item)
        {
            if (IsFull == false)
            {
                calorieIntake += item.Calories;
                ConsumptionHistory.Add(item);
                Console.WriteLine($"{item.Name} was served. Spicy? {item.IsSpicy}. Sweet?{item.IsSweet}. Calories: {item.Calories}");
            }
            else
            {
                Console.WriteLine($"SpiceHound is too full");
                if ( item.IsSpicy == true)
                {
                    Console.WriteLine("Didn't know you can lose calories from eating spices.");
                    calorieIntake -= 5;
                }
            }
        }
        public override bool IsFull
        {
            get
            {
                if (calorieIntake > 1200)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}