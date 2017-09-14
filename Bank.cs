using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Bank : Store
    {
        public int cost;

        public int SetCost()
        {
            Console.WriteLine("What are you going to charge your customers for a cup of lemonade today? Please enter your cost in cents.");
            cost = int.Parse(Console.ReadLine());
            Console.WriteLine($"Your price per cup today is ${(cost / 100).ToString("0.00")}.");
            Console.ReadLine();
            return cost;
        }

        public void CalculateCost()
        {
            double costOfLemons = priceOfLemons * lemons;
            double costOfSugar = priceOfSugar * sugar;
            double costOfIce = priceOfIce * ice;
            double todayCost = costOfLemons + costOfSugar + costOfIce;
            double moneyLeft = 20 - todayCost;
            Console.WriteLine($"You spent ${todayCost.ToString("0.00")} on supplies and you have ${moneyLeft.ToString("0.00")} left to spend tomorrow. \n\nPress enter to continue.");
            Console.ReadLine();
            //CreateRecipe();
        }

        public int CalcCostPerCup(int numberOfPitchers)
        {

        }
    }
}
