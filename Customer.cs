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

        public int calculateCustomersToday(int cost)
        {
            int customersToday = rnd.Next(20, 100);
            int buyingCustomersToday = rnd.Next(1, customersToday);
            double grossIncome = buyingCustomersToday * (cost/100);
            Console.WriteLine($"{buyingCustomersToday} people bought lemondade from you today. You took in ${grossIncome}.");
            Console.ReadLine();
            return buyingCustomersToday;

        }

    }
}
