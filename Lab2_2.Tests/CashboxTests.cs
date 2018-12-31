using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lab2_2.Tests
{
    [TestClass]
    public class CashboxTests
    {
        [TestMethod]
        public void Buy_budget1000_cost700_result300()
        {
            // arrange
            int budget = 1000;
            int cost = 700;
            int expected = 300;

            // act
            Cashbox cashbox = new Cashbox(budget);
            cashbox.Buy(cost);
            int actual = cashbox.Budget;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Buy_budget500_cost700_resultArgumentException()
        {
            // arrange
            int budget = 500;
            int cost = 700;

            // act
            Cashbox cashbox = new Cashbox(budget);
            cashbox.Buy(cost);
        }

        [TestMethod]
        public void Sell_budget300_cost500_result800()
        {
            // arrange
            int budget = 300;
            int cost = 500;
            int expected = 800;

            // act
            Cashbox cashbox = new Cashbox(budget);
            cashbox.Sell(cost);
            int actual = cashbox.Budget;

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
