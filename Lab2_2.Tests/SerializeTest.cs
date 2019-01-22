using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lab2_2.Tests
{
    [TestClass]
    public class SerializeTest
    {
        [TestMethod]
        public void SerializeDeserializeEmporium()
        {
            // arrange
            Emporium expected = new Emporium(name: "Низкоцен", budget: 100_000_000);
            expected.ExpandArea(area: 10_000_000, costOfOneCentimeter: 6);
            Department hlebobylochnie = new Department(name: "Хлебобулочные изделия", area: 1_500_000, emporium: expected);
            Food hleb = new Food(name: "Хлеб", size: 200, markup: 3.0f, department: hlebobylochnie, shelfLife: 2);
            hlebobylochnie.BuyProduct(product: hleb, quantity: 1500, price: 10);
            Department molochka = new Department(name: "Молочная продукция", area: 4_200_000, emporium: expected);
            Food moloko = new Food(name: "Молоко", size: 400, markup: 3.0f, department: molochka, shelfLife: 3);
            molochka.BuyProduct(product: moloko, quantity: 2000, price: 15);

            // act
            Emporium actual;
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("SerializeTest.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, expected);
            }
            using (FileStream fs = new FileStream("SerializeTest.dat", FileMode.OpenOrCreate))
            {
                actual = (Emporium)formatter.Deserialize(fs);
            }

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
