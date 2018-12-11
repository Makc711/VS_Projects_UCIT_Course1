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
                nizkocen.BuyArea(area:1000, costOfOneMeter:60_000);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
                return;
            }
            nizkocen.ShowInformation();

            Department hlebobylochnie = new Department(name: "Хлебобулочные", area: 20, emporium: nizkocen);
            nizkocen.ShowInformation();

            try
            {
                hlebobylochnie.ExpandArea(30);
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
                return;
            }
            nizkocen.ShowInformation();

            try
            {
                hlebobylochnie.ReduceArea(10);
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
                return;
            }
            nizkocen.ShowInformation();

            Product hleb = new Product(name:"Хлеб", size:2, markup:3.0f, department:hlebobylochnie);
            hleb.Buy(quantity:8, price:10);
            Product bylochka = new Product(name: "Булочка", size: 1, markup: 2.5f, department: hlebobylochnie);
            bylochka.Buy(quantity: 7, price: 8);
            Product pirojok = new Product(name: "Пирожок", size: 1, markup: 2.8f, department: hlebobylochnie);
            pirojok.Buy(quantity: 5, price: 6);
            nizkocen.ShowInformation();

            Console.ReadKey();
        }
    }
}
