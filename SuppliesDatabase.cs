using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class SuppliesDatabase
    {
        SqlConnection suppliesDB;
        public SuppliesDatabase()
        {
            suppliesDB = new SqlConnection("Server=GUMBY;Database=LemonadeStand;Integrated Security=true");
        }


    }
}
