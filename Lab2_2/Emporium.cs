using System;
using System.Collections.Generic;

namespace Lab2_2
{
    class Emporium
    {
        private readonly string _name;
        private int _areaOfEmporium;
        private int _freeArea;
        private readonly Cashbox _cashbox;
        private readonly List<Department> _departments = new List<Department>();

        public Emporium(string name, int budget)
        {
            _name = name;
            _cashbox = new Cashbox(budget);
        }

        public void ExpandArea(int area, int costOfOneMeter)
        {
            _cashbox.Buy(area * costOfOneMeter);
            _areaOfEmporium += area;
            _freeArea += area;
        }

        public void SellArea(int area, int costOfOneMeter)
        {
            if (_freeArea >= area)
            {
                _cashbox.Sell(area * costOfOneMeter);
                _areaOfEmporium -= area;
                _freeArea -= area;
            }
            else
            {
                throw new ArgumentException($"Продаваемая площадь {area} больше свободной площади {_freeArea}");
            }
        }

        public void CreateDepartment(string name, int area)
        {
            Department department = new Department(name, area);
            if (!_departments.Contains(department))
            {
                _departments.Add(department);
                _freeArea -= area;
            }
            else
            {
                throw new ArgumentException($"Отдел {name} уже существует");
            }
        }

        public void RemoveDepartment(string name)
        {
            if (_departments.Exists(x => x.Name == name))
            {
                Department department = _departments.Find(x => x.Name == name);
                _freeArea += department.Area;
                _departments.Remove(department);
            }
            else
            {
                throw new ArgumentException($"В универмаге нет отдела {name}");
            }
        }

        public void ExpandAreaOfDepartment(string name, int area)
        {
            if (_departments.Exists(x => x.Name == name))
            {
                if (_freeArea >= area)
                {
                    _departments.Find(x => x.Name == name).ExpandArea(area);
                    _freeArea -= area;
                }
                else
                {
                    throw new ArgumentException($"В универмаге не достаточно свободной площади ({_freeArea} < {area})");
                }
            }
            else
            {
                throw new ArgumentException($"В универмаге нет отдела {name}");
            }
        }

        public void ReduceAreaOfDepartment(string name, int area)
        {
            if (_departments.Exists(x => x.Name == name))
            {
                _departments.Find(x => x.Name == name).ReduceArea(area);
                _freeArea += area;
            }
            else
            {
                throw new ArgumentException($"В универмаге нет отдела {name}");
            }
        }

        public void ShowInformation()
        {
            Console.WriteLine($"Название: {_name}");
            Console.WriteLine($"Площадь универмага: {_areaOfEmporium:0,0} м^2");
            Console.WriteLine($"Свободная площадь:  {_freeArea:0,0} м^2");
            _cashbox.ShowFinances();
            foreach (var department in _departments)
            {
                Console.WriteLine(department);
            }
            Console.WriteLine();
        }
    }
}
