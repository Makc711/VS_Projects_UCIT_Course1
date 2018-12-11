using System;

namespace Lab2_2
{
    class Program
    {
        static void Main()
        {
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

            Department hlebobylochnie = new Department(name: "Хлебобулочные", area: 1_500_000, emporium: nizkocen);
            Product hleb = new Product(name:"Хлеб", size:200, markup:3.0f, department:hlebobylochnie);
            hleb.Buy(quantity:1500, price:10);
            Product bylochka = new Product(name: "Булочка", size: 100, markup: 2.5f, department: hlebobylochnie);
            bylochka.Buy(quantity: 800, price: 8);
            Product pirojok = new Product(name: "Пирожок", size: 84, markup: 2.8f, department: hlebobylochnie);
            pirojok.Buy(quantity: 700, price: 6);
            nizkocen.ShowInformation();

            Department molochka = new Department(name: "Молочная продукция", area: 4_200_000, emporium: nizkocen);
            Product moloko = new Product(name: "Молоко", size: 400, markup: 3.0f, department: molochka);
            moloko.Buy(quantity: 2000, price: 15);
            Product smetana = new Product(name: "Сметана", size: 200, markup: 3.0f, department: molochka);
            smetana.Buy(quantity: 1800, price: 20);
            Product kefir = new Product(name: "Кефир", size: 300, markup: 3.2f, department: molochka);
            kefir.Buy(quantity: 1600, price: 13);
            nizkocen.ShowInformation();

            hleb.Sell(quantity: 1300);
            bylochka.Sell(quantity: 700);
            pirojok.Sell(quantity: 650);
            moloko.Sell(quantity: 1800);
            smetana.Sell(quantity: 1650);
            kefir.Sell(quantity: 1380);
            nizkocen.ShowInformation();

            Console.WriteLine(hlebobylochnie[1]);

            Console.ReadKey();
        }
    }
}
