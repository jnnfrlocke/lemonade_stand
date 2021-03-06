﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class CashBox : Store
    {
        public decimal cost;
        public double todayCost;
        public double costOfLemons;
        public double costOfSugar;
        public double costOfIce;

        public decimal SetPrice()
        {
            Console.WriteLine("What are you going to charge your customers for a cup of lemonade today?");
            cost = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"Your price per cup today is ${cost.ToString("0.00")}.");
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
            return cost;
        }

        public double CalculateCost(double lemonsInRecipe, double sugarInRecipe, double iceInRecipe)

        {
            costOfLemons = priceOfLemons * lemonsInRecipe;
            costOfSugar = priceOfSugar * sugarInRecipe;
            costOfIce = priceOfIce * iceInRecipe;
            costOfLemons = Math.Round(costOfLemons, 2);
            costOfSugar = Math.Round(costOfSugar, 2);
            costOfIce = Math.Round(costOfIce, 2);
            todayCost = costOfLemons + costOfSugar + costOfIce;
            //CalculateCashLeft(todayCost);
            return todayCost;
            //Console.ReadLine();
        }

        public double CalculateCashLeft(double todayCost)
        {
            moneyLeft = startingCash - todayCost;
            if (moneyLeft < 0)
            {
                Console.WriteLine($"The total you are trying to spend, ${todayCost}, is more than you have available. Please adjust your purchases.");
                Console.ReadLine();
                BuyIngredients();
            }
            else
            {
                Console.WriteLine($"You spent ${todayCost.ToString("0.00")} on supplies and you have ${moneyLeft.ToString("0.00")} left to spend tomorrow. \n\nPress enter to continue.");
            }
            return moneyLeft;
        }

        public double CalcCostPerCup(double numberOfPitchers)
        {
            double costOfCup = Math.Round(todayCost / numberOfPitchers / 8, 2);
            Console.WriteLine($"The cost of a cup of lemonade is ${costOfCup}."  );
            return numberOfPitchers;
        }
    }
}
