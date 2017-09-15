using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Player
    {
        public CashBox setPrice = new CashBox();
        public Recipe todaysRecipe = new Recipe();
        public Customer todaySold = new Customer();
        public StandInventory todaysInventory = new StandInventory();

        public void PlayerTurn()
        {
            setPrice.CalculateCost(todaysRecipe.lemonsInRecipe, todaysRecipe.sugarInRecipe, todaysRecipe.iceInRecipe);
            setPrice.CalcCostPerCup(todaysRecipe.pitchers);
            setPrice.SetPrice();
            todaysRecipe.CreateRecipe();
            todaySold.CalculateCustomersToday(setPrice.cost);
            todaysInventory.TrackIngredients();
        }
    }
}
