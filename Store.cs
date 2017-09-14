using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Store
    {
        //to start the user has no ingredients
        public double lemons = 0;
        public double sugar = 0;
        public double ice = 0;
        public double priceOfLemons = .50;
        public double priceOfSugar = .20;
        public double priceOfIce = .10;
        

        public void BuyIngredients()
        {
            Console.WriteLine($"How many lemons do you want to purchase at ${priceOfLemons.ToString("0.00")}/lemon? Please enter a whole number.");
            lemons = double.Parse(Console.ReadLine());
            Console.WriteLine($"How many cups of sugar do you want to purchase at ${priceOfSugar.ToString("0.00")} per cup?");
            sugar = double.Parse(Console.ReadLine());
            Console.WriteLine($"How many ice cubes do you want to buy at ${priceOfIce.ToString("0.00")} per cube?");
            ice = double.Parse(Console.ReadLine());
            //TODO: make list of lemons, sugar, ice, pass into inventory class (to be created)
            Console.WriteLine($"You have {lemons} lemons, {sugar} cups of sugar, and {ice} ice cubes.");
            //setPrice.CalculateCost();
        }

        //TODO: move to bank
        //public void CalculateCost()
        //{
        //    double costOfLemons = priceOfLemons * lemons;
        //    double costOfSugar = priceOfSugar * sugar;
        //    double costOfIce = priceOfIce * ice;
        //    double todayCost = costOfLemons + costOfSugar + costOfIce;
        //    double moneyLeft = 20 - todayCost;
        //    Console.WriteLine($"You spent ${todayCost.ToString("0.00")} on supplies and you have ${moneyLeft.ToString("0.00")} left to spend tomorrow. \n\nPress enter to continue.");
        //    Console.ReadLine();
        //    CreateRecipe();
        //}

        //TODO: move to inventory??
        

        //TODO: move to iventory
        


    }
}
