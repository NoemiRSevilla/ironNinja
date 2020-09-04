using System;
using IronNinja.Classes;
using IronNinja.Interfaces;
using System.Diagnostics;

class SweetTooth : Ninja
{
    public override void Consume(IConsumable item)
    {
        if (IsFull == false)
        {
            calorieIntake = calorieIntake + item.Calories;
            ConsumptionHistory.Add(item);
            Console.WriteLine($"{item.Name} was {item.Calories} item calories served with {calorieIntake} total calories. Full? {IsFull}");
            if (item.IsSweet == true)
            {
                Console.WriteLine("Stop drinking your sweets, fatty.");
                calorieIntake += 10;
            }
        }
        else
        {
            Console.WriteLine("SweetTooth too full. Can't eat anymore");
        }
    }
    public override bool IsFull
    {
        get
        {
            if (calorieIntake > 1500)
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