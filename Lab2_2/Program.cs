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

            Department hlebobylochnie = new Department(name: "Хлебобулочные", area: 20);
            try
            {
                nizkocen.CreateDepartment(hlebobylochnie);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
                return;
            }
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

            Console.ReadKey();
        }
    }
}
