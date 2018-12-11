using System;
using System.Collections.Generic;

namespace Lab2_2
{
    class Emporium
    {
        private int _areaOfEmporium;
        private int _freeArea;
        private Cashbox _cashbox;
        private readonly List<Department> _departments = new List<Department>();
        public string Name { get; }

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

        public Emporium(string name, int budget)
        {
            Name = name;
            Cashbox = new Cashbox(budget);
        }

        public void BuyArea(int area, int costOfOneMeter)
        {
            _cashbox.Buy(area * costOfOneMeter);
            _areaOfEmporium += area;
            ClearArea(area);
        }

        public void SellArea(int area, int costOfOneMeter)
        {
            OccupyArea(area);
            _cashbox.Sell(area * costOfOneMeter);
            _areaOfEmporium -= area;
        }

        public void OccupyArea(int area)
        {
            if (_freeArea >= area)
            {
                _freeArea -= area;
            }
            else
            {
                throw new ArgumentException($"В универмаге не достаточно свободной площади ({_freeArea} < {area})");
            }
        }

        public void ClearArea(int area)
        {
            _freeArea += area;
        }

        public void AddDepartment(Department department)
        {
            if (!_departments.Contains(department))
            {
                _departments.Add(department);
            }
            else
            {
                throw new ArgumentException($"Отдел {department.Name} уже существует");
            }
        }

        public void RemoveDepartment(Department department)
        {
            if (_departments.Contains(department))
            {
                ClearArea(department.Area);
                _departments.Remove(department);
            }
            else
            {
                throw new ArgumentException($"В универмаге нет отдела {department.Name}");
            }
        }

        public void ShowInformation()
        {
            Console.WriteLine($"Название: {Name}");
            Console.WriteLine($"Площадь универмага: {_areaOfEmporium:0,0} м^2");
            Console.WriteLine($"Свободная площадь:  {_freeArea:0,0} м^2");
            _cashbox.ShowFinances();
            foreach (var department in _departments)
            {
                department.ShowInformation();
            }
            Console.WriteLine();
        }
    }
}
