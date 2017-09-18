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
            SqlCommand command = new SqlCommand("SELECT Item, Quantity, Price", suppliesDB);
            var result = command.ExecuteNonQuery();
            Console.WriteLine("gdgdfd");
          






            Console.WriteLine($"How many lemons do you want to purchase at ${priceOfLemons.ToString("0.00")} for {14}lemons? Lemons are good for a week.");
            lemons = double.Parse(Console.ReadLine());
            Console.WriteLine($"How many cups of sugar do you want to purchase at ${priceOfSugar.ToString("0.00")} per cup?");
            sugar = double.Parse(Console.ReadLine());
            Console.WriteLine($"How many ice cubes do you want to buy at ${priceOfIce.ToString("0.00")} per cube?");
            Console.WriteLine($"How many disposable cups would you like to buy at {priceOfCups.ToString("0.00")} per cup?");
            ice = double.Parse(Console.ReadLine());
            Console.WriteLine($"You have {lemons} lemons, {sugar} cups of sugar, {ice} ice cubes, and {cups}cups.");
        }

    }
}
