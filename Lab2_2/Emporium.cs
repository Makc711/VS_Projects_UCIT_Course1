using System;
using System.Collections.Generic;

namespace Lab2_2
{
    public class Emporium
    {
        public string Name { get; }
        public Cashbox Cashbox { get; }
        public Square Square { get; }
        public List<Department> Departments { get; } = new List<Department>();

        public Emporium(string name, int budget)
        {
            Name = name;
            Cashbox = new Cashbox(budget);
            Square = new Square(0);
        }

        public Emporium(string name, int budget, int area) : this(name, budget)
        {
            Square = new Square(area);
        }

        public void ExpandArea(int area, int costOfOneCentimeter)
        {
            Cashbox.Buy(area * costOfOneCentimeter);
            Square.ExpandArea(area);
        }

        public void ReduceArea(int area, int costOfOneCentimeter)
        {
            Square.ReduceArea(area);
            Cashbox.Sell(area * costOfOneCentimeter);
        }

        public void AddDepartment(Department department)
        {
            if (!Departments.Contains(department))
            {
                Square.OccupyArea(department.Square.Area);
                Departments.Add(department);
            }
            else
            {
                throw new ArgumentException($"Отдел {department.Name} уже существует");
            }
        }

        public void RemoveDepartment(Department department)
        {
            if (Departments.Contains(department))
            {
                Square.VacateArea(department.Square.Area);
                Departments.Remove(department);
            }
            else
            {
                throw new ArgumentException($"В универмаге нет отдела {department.Name}");
            }
        }

        public void ShowInformation()
        {
            Console.WriteLine($"Название: {Name}");
            Console.WriteLine($"Площадь универмага: {(double)Square.Area /10000:0,0.0} м^2");
            Console.WriteLine($"Свободная площадь:  {(double)Square.FreeArea /10000:0,0.0} м^2");
            Cashbox.ShowFinances();
            foreach (var department in Departments)
            {
                department.ShowInformation();
            }
            Console.WriteLine();
        }
    }
}
