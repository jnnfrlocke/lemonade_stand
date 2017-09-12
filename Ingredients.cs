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

        public void BuyIngredients()
        {
            Console.WriteLine("How many lemons do you want to purchase at $1.00/lemon? Please enter a whole number.");
            lemons = double.Parse(Console.ReadLine());
            Console.WriteLine("How many cups of sugar do you want to purchase at $.50 per cup?");
            sugar = double.Parse(Console.ReadLine());
            Console.WriteLine("How many ice cubes do you want to buy at $.20 per cube?");
            ice = double.Parse(Console.ReadLine());
            CreateRecipe();
        }

        public void CreateRecipe()
        {
            double lemonsInRecipe = 0;
            double sugarInRecipe = 0;
            double iceInRecipe = 0;
            Console.WriteLine($"You have {lemons} lemons, {sugar} cups of sugar, and {ice} ice cubes.");
            Console.WriteLine("Now that you have your ingredients, it's time to make your lemonade. How many lemons will you use in today's batch?");
            lemonsInRecipe = double.Parse(Console.ReadLine());
            Console.WriteLine("How many cups of sugar will you use?");
            sugarInRecipe = double.Parse(Console.ReadLine());
            Console.WriteLine("How many ice cubes will you use?");
            iceInRecipe = double.Parse(Console.ReadLine());
        }
    }
}
