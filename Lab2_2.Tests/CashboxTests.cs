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
    }
}
