using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;

namespace LemonadeStand
{
    public class Store : Warehouse
    {        
        public double priceOfLemons = .50;
        public double priceOfSugar = .20;
        public double priceOfIce = .10;
        public double priceOfCups = .20;
 

        SqlConnection suppliesDB;
        public void SuppliesDatabase()
        {
            suppliesDB = new SqlConnection("Server=GUMBY;Database=LemonadeStand;Integrated Security=true");
        }


        public void BuyIngredients()
        {
            SuppliesDatabase();
            suppliesDB.Open();
            SqlCommand command = new SqlCommand("SELECT Item, Quantity, Price from supplies_data", suppliesDB);
            var result = command.ExecuteNonQuery();
            //Console.WriteLine(result);  Prints result of -1, TODO: fix later

            Console.WriteLine($"How many lemons do you want to purchase at ${priceOfLemons.ToString("0.00")} for 14 lemons? Lemons are good for a week.");
            lemons = double.Parse(Console.ReadLine());
            //todaysIngredients.Add(lemons * 14);
            Console.WriteLine($"How many cups of sugar do you want to purchase at ${priceOfSugar.ToString("0.00")} per 10 cups?");
            sugar = double.Parse(Console.ReadLine());
            //todaysIngredients.Add(sugar * 10);
            Console.WriteLine($"How many ice cubes do you want to buy at ${priceOfIce.ToString("0.00")} per 100 cubes?");
            ice = double.Parse(Console.ReadLine());
            //todaysIngredients.Add(ice * 100);
            Console.WriteLine($"How many disposable cups would you like to buy at {priceOfCups.ToString("0.00")} per 25 cups?");
            cups = double.Parse(Console.ReadLine());
            //todaysIngredients.Add(cups * 25);
            Console.WriteLine($"You have {lemons} lemons, {sugar} cups of sugar, {ice} ice cubes, and {cups} cups.");
            AddTodaysIngredients();
        }
            //return todaysIngredients;

            //AddTodaysIngredients();
            public double[] AddTodaysIngredients()
        {
            todaysIngredientArray[0] = lemons * 14;
            todaysIngredientArray[1] = sugar * 10;
            todaysIngredientArray[2] = ice * 100;
            todaysIngredientArray[3] = cups * 25;
            return todaysIngredientArray;
        }

    }

    }
