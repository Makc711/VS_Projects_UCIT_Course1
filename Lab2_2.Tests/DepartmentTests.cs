using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lab2_2.Tests
{
    [TestClass]
    public class DepartmentTests
    {
        [TestMethod]
        public void ExpandArea_start500_add200_result700()
        {
            // arrange
            int budget = 1000;
            int emporiumArea = 1000;
            int departmentArea = 500;
            int addArea = 200;
            int expectedDepartmentArea = 700;
            int expectedDepartmentFreeArea = 700;

            // act
            Emporium nizkocen = new Emporium(name: "Низкоцен", budget: budget, area:emporiumArea);
            Department hlebobylochnie = new Department(name: "Хлебобулочные", area: departmentArea, emporium: nizkocen);
            hlebobylochnie.ExpandArea(addArea);
            int actualDepartmentArea = hlebobylochnie.Square.Area;
            int actualDepartmentFreeArea = hlebobylochnie.Square.FreeArea;

            // assert
            Assert.AreEqual(expectedDepartmentArea, actualDepartmentArea);
            Assert.AreEqual(expectedDepartmentFreeArea, actualDepartmentFreeArea);
        }

        [TestMethod]
        public void ReduceArea_start700_remove200_result500()
        {
            // arrange
            int budget = 1000;
            int emporiumArea = 1000;
            int departmentArea = 700;
            int removeArea = 200;
            int expectedDepartmentArea = 500;
            int expectedDepartmentFreeArea = 500;

            // act
            Emporium nizkocen = new Emporium(name: "Низкоцен", budget: budget, area: emporiumArea);
            Department hlebobylochnie = new Department(name: "Хлебобулочные", area: departmentArea, emporium: nizkocen);
            hlebobylochnie.ReduceArea(removeArea);
            int actualDepartmentArea = hlebobylochnie.Square.Area;
            int actualDepartmentFreeArea = hlebobylochnie.Square.FreeArea;

            // assert
            Assert.AreEqual(expectedDepartmentArea, actualDepartmentArea);
            Assert.AreEqual(expectedDepartmentFreeArea, actualDepartmentFreeArea);
        }
    }
}
