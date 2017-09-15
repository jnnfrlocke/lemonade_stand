﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class StandInventory : Warehouse
    {
        public double lemonsInRecipe;
        public double sugarInRecipe;
        public double iceInRecipe;
        
        public void TrackIngredients()
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
            Console.WriteLine($"Your ingredients at the end of the day will be {updatedIngredients[0]} lemons, {updatedIngredients[1]} cups of sugar, and {updatedIngredients[2]} ice cubes. \nPress enter to continue.");
            Console.ReadLine();
        }
    }
}