using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {

        public void RunGame()
        {
            IntroduceGame();
            DisplayTodaysWeather();
            BuyIngredients();
        }

        public void IntroduceGame()
        {
            Console.WriteLine("Welcome to Lemonade Stand. As you might have guessed, you'll be running your own lemonade stand. You'll take into account the weather and other factors to determine your recipe, to decide how much lemonade to make, to determine your price, and decide if and how much to advertise. \n\nWith your first $20 you'll purchase your supplies. Then you start selling! \n\nPress enter to continue.");
            Console.ReadLine();
        }

        public void DisplayTodaysWeather()
        {
            Weather todayWeather = new Weather();
            todayWeather.Temp();
            todayWeather.Sun();
            todayWeather.WindSpeed();
            todayWeather.Humid();
            Console.WriteLine($"Today the temperature is forecast to be {todayWeather.temperature} degrees Farenheit. \nIt will be {todayWeather.sunny} with winds of {todayWeather.wind}mph and {todayWeather.humidity}% humidity.");
            Console.ReadLine();
        }

        public void BuyIngredients()
        {
            Ingredients todayRecipe = new Ingredients();

            Console.WriteLine("How many lemons do you want to purchase at $1.00/lemon? Please enter a whole number.");
            todayRecipe.lemons = double.Parse(Console.ReadLine());

            Console.WriteLine("How many cups of sugar do you want to purchase at $.50 per cup?");
            todayRecipe.sugar = double.Parse(Console.ReadLine());

            Console.WriteLine("How many ice cubes do you want to buy at $.20 per cube?");
            todayRecipe.ice = double.Parse(Console.ReadLine());             
        }

            }
        
        }
        