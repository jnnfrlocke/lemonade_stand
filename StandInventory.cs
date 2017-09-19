using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class StandInventory : Warehouse
    {
        public int pitchers;

        public double lemonsInRecipe;
        public double sugarInRecipe;
        public double iceInRecipe;
        public List<double> recipeIngredients = new List<double>();

        public void TrackIngredients()
        {
            double newLemonStock;
            double newSugarStock;
            double newIceStock;
            double newCupStock;

            List<double> updatedIngredients = new List<double>();
            newLemonStock = todaysIngredientArray[0] - lemonsInRecipe;
            updatedIngredients.Add(newLemonStock);
            newSugarStock = todaysIngredientArray[1] - sugarInRecipe;
            updatedIngredients.Add(newSugarStock);
            newIceStock = todaysIngredientArray[2]  - iceInRecipe;
            updatedIngredients.Add(newIceStock);
            newCupStock = todaysIngredientArray[3] - (pitchers * 8);

            Console.WriteLine($"Your ingredients at the end of the day will be {updatedIngredients[0]} lemons, {updatedIngredients[1]} cups of sugar, and {updatedIngredients[2]} ice cubes. \nPress enter to continue.");
            Console.ReadLine();
        }
    }
}
