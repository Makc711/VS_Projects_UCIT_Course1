using System;

namespace Lab2_2
{
    class Program
    {
        static void Main()
        {
            Emporium emporium = new Emporium(name:"Низкоцен", budget:100_000_000);
            try
            {
                emporium.ExpandArea(area:1000, costOfOneMeter:60_000);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
                return;
            }
            emporium.ShowInformation();

            try {
                emporium.CreateDepartment(name: "Хлебобулочные", area: 20);
            } catch (ArgumentException e) {
                Console.WriteLine(e.Message);
                Console.ReadKey();
                return;
            }
            emporium.ShowInformation();

            try
            {
                emporium.ExpandAreaOfDepartment(name: "Хлебобулочные", area: 30);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
                return;
            }
            emporium.ShowInformation();

            try
            {
                emporium.ReduceAreaOfDepartment(name: "Хлебобулочные", area: 10);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
                return;
            }
            emporium.ShowInformation();

            Console.ReadKey();
        }
    }
}
