using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LemonadeStand;

namespace LemonadeStandTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Return_Price_SetPrice()
        {
            //Arrange
            CashBox returnPrice = new CashBox();
            decimal expectedResult = 1;
            decimal actualResult;
            //Act
            actualResult = returnPrice.SetPrice();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
