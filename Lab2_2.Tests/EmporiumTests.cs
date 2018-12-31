using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lab2_2.Tests
{
    [TestClass]
    public class EmporiumTests
    {
        [TestMethod]
        public void ExpandArea_start500_add200_result700()
        {
            // arrange
            int budget = 10_000;
            int costOfOneCentimeter = 10;
            int startArea = 500;
            int addArea = 200;
            int expectedBudget = 8000;
            int expectedArea = 700;

            // act
            Emporium nizkocen = new Emporium(name: "Низкоцен", budget: budget, area: startArea);
            nizkocen.ExpandArea(addArea, costOfOneCentimeter);
            int actualBudget = nizkocen.Cashbox.Budget;
            int actualArea = nizkocen.Square.Area;

            // assert
            Assert.AreEqual(expectedBudget, actualBudget);
            Assert.AreEqual(expectedArea, actualArea);
        }

        [TestMethod]
        public void ReduceArea_start700_add200_result500()
        {
            // arrange
            int budget = 8000;
            int costOfOneCentimeter = 10;
            int startArea = 700;
            int removeArea = 200;
            int expectedBudget = 10_000;
            int expectedArea = 500;

            // act
            Emporium nizkocen = new Emporium(name: "Низкоцен", budget: budget, area: startArea);
            nizkocen.ReduceArea(removeArea, costOfOneCentimeter);
            int actualBudget = nizkocen.Cashbox.Budget;
            int actualArea = nizkocen.Square.Area;

            // assert
            Assert.AreEqual(expectedBudget, actualBudget);
            Assert.AreEqual(expectedArea, actualArea);
        }
    }
}
