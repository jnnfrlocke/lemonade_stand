using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Game
    {

        public void RunGame()
        {
            IntroduceGame();
            todayWeather.DisplayTodaysWeather();
            todayStock.BuyIngredients();
            setPrice.SetCost();
            todaySold.calculateCustomersToday(setPrice.cost);
        }

        public Weather todayWeather = new Weather();
        public Store todayStock = new Store();
        public Customer todaySold = new Customer();
        public Bank setPrice = new Bank();

        public void IntroduceGame()
        {
            Console.WriteLine("Welcome to Lemonade Stand. As you might have guessed, you'll be running your own lemonade stand. You'll take into account the weather and other factors to determine your recipe, to decide how much lemonade to make, to determine your price, and decide if and how much to advertise. \n\nWith your first $20 you'll purchase your supplies. Then you start selling! \n\nPress enter to continue.");
            Console.ReadLine();
        }
        
        
        
        }

            }
        
        
        