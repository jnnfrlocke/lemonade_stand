using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LemonadeStand;

namespace LemonadeStandTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_SupplyCost_ReturnTotalCost()
        {
            //Arrange
            CashBox returnCost = new CashBox();
            double expectedResult = 2.4;
            double actualResult;
            //Act
            actualResult = returnCost.CalculateCost(3, 3, 3);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void Find_CashLeft_ReturnCashLeft()
            {
            //Arrange
            CashBox returnCashLeft = new CashBox();
            double todayCost = 2.4;
            double startingCash = 20;
            double expectedResult = startingCash - todayCost;
            //Act
            double actualResult = returnCashLeft.CalculateCashLeft(todayCost);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
            }
        //[TestMethod]
        //public void ()
        //    {
        //    //Arrange

        //    //Act

        //    //Assert

        //    }
    }
}
