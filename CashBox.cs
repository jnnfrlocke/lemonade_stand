using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class CashBox : Store
    {
        public double cost;
        public double todayCost;

        public double SetPrice()
        {
            Console.WriteLine("What are you going to charge your customers for a cup of lemonade today?");
            cost = double.Parse(Console.ReadLine());
            Console.WriteLine($"Your price per cup today is ${cost.ToString("0.00")}.");
            Console.ReadLine();
            return cost;
        }

        public void CalculateCost(double lemonsInRecipe, double sugarInRecipe, double iceInRecipe)
        {
            double costOfLemons = priceOfLemons * lemonsInRecipe;
            double costOfSugar = priceOfSugar * sugarInRecipe;
            double costOfIce = priceOfIce * iceInRecipe;
            todayCost = costOfLemons + costOfSugar + costOfIce;
            double moneyLeft = 20 - todayCost;
            Console.WriteLine($"You spent ${todayCost.ToString("0.00")} on supplies and you have ${moneyLeft.ToString("0.00")} left to spend tomorrow. \n\nPress enter to continue.");
            Console.ReadLine();
        }

        public void CalcCostPerCup(double numberOfPitchers)
        {
            double costOfCup = Math.Round(todayCost / numberOfPitchers / 8, 2);
            Console.WriteLine($"The cost of a cup of lemonade is ${costOfCup}."  );
        }
    }
}
