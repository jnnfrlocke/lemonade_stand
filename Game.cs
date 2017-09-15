using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Game
    {

        public Weather todayWeather = new Weather();
        public Store todayStock = new Store();
        public Player playerOne = new Player();

        public void RunGame()
        {
            IntroduceGame();
            EstablishPlayers();
            GameLength();
            todayWeather.DisplayTodaysWeather();
            todayStock.BuyIngredients();
            playerOne.PlayerTurn();
        }      
              

        public void IntroduceGame()
        {
            Console.WriteLine("Welcome to Lemonade Stand. \nAs you might have guessed, you'll be running your own lemonade stand, taking into account the weather and other factors to determine your recipe, to decide how much lemonade to make, to determine your price, and decide if and how much to advertise. \nYou start with $20 to purchase your supplies. Then you start selling! \nPress enter to continue.");
            Console.ReadLine();
        }
        
        public void EstablishPlayers ()
        {
            Console.WriteLine("Enter number of players: 1 or 2.");
            Console.ReadLine();
        }

        public void GameLength ()
        {
            Console.WriteLine("Would you like to play for 7, 14, 21, or 28 days?");
            Console.ReadLine();
        }
    }
}
        
        
        