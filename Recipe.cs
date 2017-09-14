﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Recipe : Inventory
    {
        
        public int pitchers;
        public int CreateRecipe()
        {
            Console.WriteLine("Now that you have your ingredients, it's time to make your lemonade. \nHow many lemons will you use in today's batch?");
            lemonsInRecipe = double.Parse(Console.ReadLine());
            Console.WriteLine("How many cups of sugar will you use?");
            sugarInRecipe = double.Parse(Console.ReadLine());
            Console.WriteLine("How many ice cubes will you use?");
            iceInRecipe = double.Parse(Console.ReadLine());
            Console.WriteLine($"Your recipe today is {lemonsInRecipe} lemons, {sugarInRecipe} cups of sugar, and {iceInRecipe} ice cubes. \nHow many pitchers will you make using these ingredients? Keep in mind each pitcher can hold 8 cups of lemonade. \nPress enter to continue.");
            pitchers = int.Parse(Console.ReadLine());
            //setPrice.CalcCostPerCup(pitchers); //TODO
            //TrackIngredients();
            return pitchers;
        }

    }
}
