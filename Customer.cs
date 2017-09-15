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

        public double CalculateCustomersToday(double price)
        {
            double customersToday = rnd.Next(20, 100);
            string customersPossible = customersToday.ToString();
            int custPossible = int.Parse(customersPossible);
            double buyingCustomersToday = rnd.Next(1, custPossible);
            double grossIncome = Math.Round(buyingCustomersToday * price, 2);
            Console.WriteLine($"{buyingCustomersToday} people bought lemondade from you today. You took in ${grossIncome}.");
            Console.ReadLine();
            return buyingCustomersToday;
        }

    }
}
