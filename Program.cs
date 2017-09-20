using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Program
    {
        static void Main(string[] args)
        {
            //UnitTest1 newTest = new UnitTest1;
            //newTest.Return_Price_SetPrice();

            Game newGame = new Game();
            newGame.InitializeGame();
        }
    }
}
