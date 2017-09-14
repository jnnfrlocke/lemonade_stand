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
            todayWeather.DisplayTodaysWeather();
            todayStock.BuyIngredients();
            SetCost();
            todaySold.calculateCustomersToday(cost);
        }

        public Weather todayWeather = new Weather();
        public Ingredients todayStock = new Ingredients();
        public Customer todaySold = new Customer();
        public int cost;

        public void IntroduceGame()
        {
            Console.WriteLine("Welcome to Lemonade Stand. As you might have guessed, you'll be running your own lemonade stand. You'll take into account the weather and other factors to determine your recipe, to decide how much lemonade to make, to determine your price, and decide if and how much to advertise. \n\nWith your first $20 you'll purchase your supplies. Then you start selling! \n\nPress enter to continue.");
            Console.ReadLine();
        }
        
        public int SetCost()
        {
            Console.WriteLine("What are you going to charge your customers for a cup of lemonade today? Please enter your cost in cents.");
            cost = int.Parse(Console.ReadLine());
            Console.WriteLine($"Your price per cup today is ${(cost/100).ToString("0.00")}.");
            Console.ReadLine();
            return cost;
        }
        
        }

            }
        
        
        