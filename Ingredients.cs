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

        
    }
}
