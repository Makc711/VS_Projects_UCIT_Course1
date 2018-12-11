using System;
using System.Collections.Generic;

namespace Lab2_2
{
    class Emporium : Square
    {
        private Cashbox _cashbox;
        public string Name { get; }
        public List<Department> Departments { get; } = new List<Department>();

        public Emporium(string name, int budget)
        {
            Name = name;
            Cashbox = new Cashbox(budget);
        }

        public Emporium(string name, int budget, int area) : this(name, budget)
        {
            Area = area;
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

        public void ExpandArea(int area, int costOfOneCentimeter)
        {
            Cashbox.Buy(area * costOfOneCentimeter);
            base.ExpandArea(area);
        }

        public void ReduceArea(int area, int costOfOneCentimeter)
        {
            base.ReduceArea(area);
            Cashbox.Sell(area * costOfOneCentimeter);
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
