using System;
using System.Collections.Generic;

namespace Lab2_2
{
    class Emporium
    {
        private Cashbox _cashbox;
        public string Name { get; }
        public int Area { get; private set; } // Площадь, см^2
        public int FreeArea { get; private set; }
        public List<Department> Departments { get; } = new List<Department>();

        public Emporium(string name, int budget)
        {
            Name = name;
            Cashbox = new Cashbox(budget);
        }

        public Cashbox Cashbox
        {
            get => _cashbox;
            set
            {
                if (_cashbox == null)
                {
                    _cashbox = value;
                }
            }
        }

        public void BuyArea(int area, int costOfOneCentimeter)
        {
            Cashbox.Buy(area * costOfOneCentimeter);
            Area += area;
            ClearArea(area);
        }

        public void SellArea(int area, int costOfOneCentimeter)
        {
            OccupyArea(area);
            Cashbox.Sell(area * costOfOneCentimeter);
            Area -= area;
        }

        public void OccupyArea(int area)
        {
            if (FreeArea >= area)
            {
                FreeArea -= area;
            }
            else
            {
                throw new ArgumentException($"В универмаге не достаточно свободной площади ({FreeArea} < {area})");
            }
        }

        public void ClearArea(int area)
        {
            FreeArea += area;
        }

        public void AddDepartment(Department department)
        {
            if (!Departments.Contains(department))
            {
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
                ClearArea(department.Area);
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
            Console.WriteLine($"Площадь универмага: {(double)Area /10000:0,0.0} м^2");
            Console.WriteLine($"Свободная площадь:  {(double)FreeArea /10000:0,0.0} м^2");
            Cashbox.ShowFinances();
            foreach (var department in Departments)
            {
                department.ShowInformation();
            }
            Console.WriteLine();
        }
    }
}
