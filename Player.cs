using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Player
    {
        string playerOneName;
        string playerTwoName;
        public CashBox setPrice = new CashBox();
        public Recipe todaysRecipe = new Recipe();
        public Customer todaySold = new Customer();
        public StandInventory todaysInventory = new StandInventory();


        public void EstablishPlayers()
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
            else
            {
                Console.WriteLine("That was an incorrect entry. Press enter to continue.");
                Console.ReadLine();
                EstablishPlayers();
            }
            PlayersSaver(playerOneName, playerTwoName);
        }

        public SqlConnection playersConnection;
        public void PlayersSaver(string player1Name, string player2Name)
        {
            playersConnection = new SqlConnection("Server=Gumby;Database=LemonadeStand;Integrated Security=true");
            playersConnection.Open();
            SqlCommand savingPlayerOne = new SqlCommand($"insert into players values('{playerOneName}', playersConnection) where id = 1");
            SqlCommand savingPlayerTwo = new SqlCommand($"insert into players values('{playerTwoName}', playersConnection) where id = 2");
        }


        public void PlayerTurn()
        {
            todaysRecipe.CreateRecipe();
            setPrice.CalculateCost(todaysRecipe.lemonsInRecipe, todaysRecipe.sugarInRecipe, todaysRecipe.iceInRecipe);
            setPrice.CalcCostPerCup(todaysRecipe.pitchers);
            setPrice.SetPrice();
            todaySold.CalculateCustomersToday(setPrice.cost, todaysRecipe.pitchers);
            todaysInventory.TrackIngredients();
        }
    }
}
