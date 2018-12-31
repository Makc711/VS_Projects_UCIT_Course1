using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lab2_2.Tests
{
    [TestClass]
    public class SquareTests
    {
        [TestMethod]
        public void ExpandArea_start500_add200_result700()
        {
            // arrange
            int startArea = 500;
            int addArea = 200;
            int expectedArea = 700;
            int expectedFreeArea = 700;

            // act
            Square square = new Square(startArea);
            square.ExpandArea(addArea);
            int actualArea = square.Area;
            int actualFreeArea = square.FreeArea;

            // assert
            Assert.AreEqual(expectedArea, actualArea);
            Assert.AreEqual(expectedFreeArea, actualFreeArea);
        }

        [TestMethod]
        public void ReduceArea_start700_remove200_result500()
        {
            // arrange
            int startArea = 700;
            int removeArea = 200;
            int expectedArea = 500;
            int expectedFreeArea = 500;

            // act
            Square square = new Square(startArea);
            square.ReduceArea(removeArea);
            int actualArea = square.Area;
            int actualFreeArea = square.FreeArea;

            // assert
            Assert.AreEqual(expectedArea, actualArea);
            Assert.AreEqual(expectedFreeArea, actualFreeArea);
        }

        [TestMethod]
        public void OccupyArea_start700_remove200_result500()
        {
            // arrange
            int startArea = 700;
            int removeArea = 200;
            int expectedArea = 700;
            int expectedFreeArea = 500;

            // act
            Square square = new Square(startArea);
            square.OccupyArea(removeArea);
            int actualArea = square.Area;
            int actualFreeArea = square.FreeArea;

            // assert
            Assert.AreEqual(expectedArea, actualArea);
            Assert.AreEqual(expectedFreeArea, actualFreeArea);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void OccupyArea_start700_remove900_resultArgumentException()
        {
            // arrange
            int startArea = 700;
            int removeArea = 900;

            // act
            Square square = new Square(startArea);
            square.OccupyArea(removeArea);
        }

        [TestMethod]
        public void VacateArea_start500_add200_result700()
        {
            // arrange
            int startArea = 700;
            int occupyArea = 200;
            int cleanArea = 200;
            int expectedArea = 700;
            int expectedFreeArea = 700;

            // act
            Square square = new Square(startArea);
            square.OccupyArea(occupyArea);
            square.VacateArea(cleanArea);
            int actualArea = square.Area;
            int actualFreeArea = square.FreeArea;

            // assert
            Assert.AreEqual(expectedArea, actualArea);
            Assert.AreEqual(expectedFreeArea, actualFreeArea);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void VacateArea_start500_add400_resultArgumentException()
        {
            // arrange
            int startArea = 700;
            int occupyArea = 200;
            int cleanArea = 400;

            // act
            Square square = new Square(startArea);
            square.OccupyArea(occupyArea);
            square.VacateArea(cleanArea);
        }
    }
}
