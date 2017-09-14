using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Store : Supplies
    {        
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
            Console.WriteLine($"You have {lemons} lemons, {sugar} cups of sugar, and {ice} ice cubes.");
        }

    }
}
