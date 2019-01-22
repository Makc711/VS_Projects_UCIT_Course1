using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Lab2_2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("   #####   Создаем универмаг \"Низкоцен\"   #####");
            Emporium nizkocen = new Emporium(name:"Низкоцен", budget:100_000_000);
            try
            {
                nizkocen.ExpandArea(area:10_000_000, costOfOneCentimeter:6);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
                return;
            }
            nizkocen.ShowInformation();

            Console.WriteLine("   #####   Создаем отдел \"Хлебобулочные изделия\" и закупаем продукцию   #####");
            Department hlebobylochnie = new Department(name: "Хлебобулочные изделия", area: 1_500_000, emporium: nizkocen);
            Food hleb = new Food(name: "Хлеб", size: 200, markup: 3.0f, department: hlebobylochnie, shelfLife: 2);
            hlebobylochnie.BuyProduct(product: hleb, quantity: 1500, price:10);
            Food bylochka = new Food(name: "Булочка", size: 100, markup: 2.5f, department: hlebobylochnie, shelfLife: 2);
            hlebobylochnie.BuyProduct(product: bylochka, quantity: 800, price: 8);
            Food pirojok = new Food(name: "Пирожок", size: 84, markup: 2.8f, department: hlebobylochnie, shelfLife: 2);
            hlebobylochnie.BuyProduct(product: pirojok, quantity: 700, price: 6);
            nizkocen.ShowInformation();

            Console.WriteLine("   #####   Создаем отдел \"Молочная продукция\" и закупаем продукцию   #####");
            Department molochka = new Department(name: "Молочная продукция", area: 4_200_000, emporium: nizkocen);
            Food moloko = new Food(name: "Молоко", size: 400, markup: 3.0f, department: molochka, shelfLife: 3);
            molochka.BuyProduct(product: moloko, quantity: 2000, price: 15);
            Food smetana = new Food(name: "Сметана", size: 200, markup: 3.0f, department: molochka, shelfLife: 3);
            molochka.BuyProduct(product: smetana, quantity: 1800, price: 20);
            Food kefir = new Food(name: "Кефир", size: 300, markup: 3.2f, department: molochka, shelfLife: 3);
            molochka.BuyProduct(product: kefir, quantity: 1600, price: 13);
            nizkocen.ShowInformation();

            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("Nizkocen.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, nizkocen);
                Console.WriteLine();
                Console.WriteLine("*** Объект сериализован");
                Console.WriteLine();
            }

            Console.WriteLine("   #####   Продаем хлебобулочную и молочную продукцию   #####");
            try
            {
                hlebobylochnie.SellProduct(product: hleb, quantity: 1300);
            }
            catch (ArgumentException)
            {
                hlebobylochnie.SellProduct(product: hleb, quantity: hleb.Quantity);
            }
            
            hlebobylochnie.SellProduct(product: bylochka, quantity: 700);
            hlebobylochnie.SellProduct(product: pirojok, quantity: 650);
            molochka.SellProduct(product: moloko, quantity: 1800);
            molochka.SellProduct(product: smetana, quantity: 1650);
            molochka.SellProduct(product: kefir, quantity: 1380);
            nizkocen.ShowInformation();

            Console.WriteLine("   #####   Пример обращения к продукту отдела по индексу   #####");
            Console.WriteLine(hlebobylochnie[1]);

            using (FileStream fs = new FileStream("Nizkocen.dat", FileMode.OpenOrCreate))
            {
                Emporium deserilizeNizkocen = (Emporium)formatter.Deserialize(fs);
                Console.WriteLine();
                Console.WriteLine("*** Объект десериализован");
                Console.WriteLine();
                deserilizeNizkocen.ShowInformation();
            }

            Console.ReadKey();
        }
    }
}
