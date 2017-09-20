using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Customer
    {
        public Random rnd = new Random();
        //    customersToday = new Random();
        //public Random buyCustomersToday = new Random();

        public decimal CalculateCustomersToday(decimal price, int numberOfPitchers)
        {
            double customersToday = rnd.Next(20, 100);
            string customersPossible = customersToday.ToString();
            int custPossible = int.Parse(customersPossible);
            decimal buyingCustomersToday = rnd.Next(1, (numberOfPitchers*8));
            decimal grossIncome = Math.Round(buyingCustomersToday * price, 2);
            //decimal netIncome = todayStock.moneyLeft - grossIncome;
            Console.WriteLine($"{buyingCustomersToday} people bought lemondade from you today. You took in ${grossIncome}.\nPress enter to continue.");
            Console.ReadLine();
            return buyingCustomersToday;
        }



    }
}
