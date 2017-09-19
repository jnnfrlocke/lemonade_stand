using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Game
    {

        public Weather todayWeather = new Weather();
        public Store todayStock = new Store();
        public Player players = new Player();

        public void InitializeGame()
        {
            IntroduceGame();
            players.EstablishPlayers();
            GameLength();            
        }      
              
        public void GamePlay()
        {
            todayWeather.DisplayTodaysWeather();
            todayStock.BuyIngredients();
            players.PlayerTurn();
        }

        public void IntroduceGame()
        {
            Console.WriteLine("Welcome to Lemonade Stand. \nAs you might have guessed, you'll be running your own lemonade stand, taking into account the weather and other factors to determine your recipe, to decide how much lemonade to make, to determine your price, and decide if and how much to advertise. \nYou start with $20 to purchase your supplies. Then you start selling! \nPress enter to continue.");
            Console.ReadLine();
        }        

        public void GameLength ()
        {
            Console.WriteLine("Would you like to play for 7, 14, 21, or 28 days?");
            int gameLength = int.Parse(Console.ReadLine());// TODO: Set game play for # of days and loop game for that amount
            switch (gameLength)
            {
                case 7:
                    int repeat = 7;
                    for (int i = 0; i < repeat; i++)
                    {
                        GamePlay();
                    }
                    break;
                case 14:
                    repeat = 14;
                    {
                        GamePlay();
                    }
                    break;
                case 21:
                    repeat = 21;
                    {
                        GamePlay();
                    }
                    break;
                case 28:
                    repeat = 28;
                    {
                        GamePlay();
                    }
                    break;
                default:
                    Console.WriteLine("Please enter a valid response. \nPress enter to continue.");
                    Console.ReadLine();
                    GameLength();
                    break;
            }
        }
    }
}
        
        
        