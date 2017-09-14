using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Recipe : Ingredients
    {        public void CreateRecipe()
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
