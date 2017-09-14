using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Ingredients
    {
        //to start the user has no ingredients
        public double lemons = 0;
        public double sugar = 0;
        public double ice = 0;
        public double priceOfLemons = .50;
        public double priceOfSugar = .20;
        public double priceOfIce = .10;
        public double lemonsInRecipe = 0;
        public double sugarInRecipe = 0;
        public double iceInRecipe = 0;

        public void BuyIngredients()
        {
            Console.WriteLine($"How many lemons do you want to purchase at ${priceOfLemons.ToString("0.00")}/lemon? Please enter a whole number.");
            lemons = double.Parse(Console.ReadLine());
            Console.WriteLine($"How many cups of sugar do you want to purchase at ${priceOfSugar.ToString("0.00")} per cup?");
            sugar = double.Parse(Console.ReadLine());
            Console.WriteLine($"How many ice cubes do you want to buy at ${priceOfIce.ToString("0.00")} per cube?");
            ice = double.Parse(Console.ReadLine());
            Console.WriteLine($"You have {lemons} lemons, {sugar} cups of sugar, and {ice} ice cubes.");
            CalculateCost();
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
            CreateRecipe();
        }

        
        public void CreateRecipe()
        {
            Console.WriteLine("Now that you have your ingredients, it's time to make your lemonade. \nHow many lemons will you use in today's batch?");
            lemonsInRecipe = double.Parse(Console.ReadLine());
            Console.WriteLine("How many cups of sugar will you use?");
            sugarInRecipe = double.Parse(Console.ReadLine());
            Console.WriteLine("How many ice cubes will you use?");
            iceInRecipe = double.Parse(Console.ReadLine());
            Console.WriteLine($"Your recipe today is {lemonsInRecipe} lemons, {sugarInRecipe} cups of sugar, and {iceInRecipe} ice cubes. \nPress enter to continue.");
            Console.ReadLine();
            TrackIngredients();
        }

        public void  TrackIngredients()
        {
            double newLemonStock;
            double newSugarStock;
            double newIceStock;
            List<double> updatedIngredients = new List<double>();
            newLemonStock = lemons - lemonsInRecipe;
            updatedIngredients.Add(newLemonStock);
            newSugarStock = sugar - sugarInRecipe;
            updatedIngredients.Add(newSugarStock);
            newIceStock = ice - iceInRecipe;
            updatedIngredients.Add(newIceStock);
            Console.WriteLine($"Your ingredients at the end of the day will be {updatedIngredients[0]} lemons, {updatedIngredients[1]} cups of sugar, and {updatedIngredients[2]} ice cubes. \n\nPress enter to continue.");
            Console.ReadLine();
        }


    }
}
