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
        public Player playerOne = new Player();
        string playerOneName;
        string playerTwoName;

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
            int players = int.Parse(Console.ReadLine());
            // Add players to db
            if (players == 1)
            {
                Console.WriteLine("Please enter your name");
                playerOneName = Console.ReadLine();
                playerTwoName = "CADIE"; // after Cognitive Autoheuristic Distributed-Intelligence Entity, from Google's 2009 April Fools Story (https://archive.google.com/cadie/)
            }
            else if (players == 2)
            {
                Console.WriteLine("Player one, please enter your name.");
                playerOneName = Console.ReadLine();
                Console.WriteLine("Player two, please enter your name.");
                playerTwoName = Console.ReadLine();
            }
            PlayersSaver(playerOneName, playerTwoName);
            //SavePlayers(playerOneName, playerTwoName);
        }

        SqlConnection playersConnection;
        public void PlayersSaver(string player1Name, string player2Name)
        {
            playersConnection = new SqlConnection("Server=Gumby;Database=LemonadeStandDB;Integrated Security=true");
            playersConnection.Open();
            SqlCommand savingPlayerOne = new SqlCommand($"insert into players values('{playerOneName}', playersConnection) where id = 1");
            SqlCommand savingPlayerTwo = new SqlCommand($"insert into players values('{playerTwoName}', playersConnection) where id = 2");
        }


        public void GameLength ()
        {
            Console.WriteLine("Would you like to play for 7, 14, 21, or 28 days?");
            Console.ReadLine();// TODO: Set game play for # of days and loop game for that amount
        }
    }
}
        
        
        