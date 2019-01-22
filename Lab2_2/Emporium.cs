using System;
using System.Collections.Generic;

namespace Lab2_2
{
    [Serializable]
    public class Emporium : IEquatable<Emporium>
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
            try
            {
                Cashbox.Buy(area * costOfOneCentimeter);
            }
            catch (ArgumentException)
            {
                area = Cashbox.Budget / costOfOneCentimeter;
                Cashbox.Buy(area * costOfOneCentimeter);
            }
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
                throw new ArgumentException($"Отдел \"{department.Name}\" уже существует");
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
                throw new ArgumentException($"В универмаге нет отдела \"{department.Name}\"");
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

        public bool Equals(Emporium other)
        {
            if (ReferenceEquals(null, other))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (Departments.Count != other.Departments.Count)
                return false;
            for (int i = 0; i < Departments.Count; i++)
            {
                if (!Equals(Departments[i], other.Departments[i]))
                    return false;
            }
            return string.Equals(Name, other.Name) && 
                Equals(Cashbox, other.Cashbox) && 
                Equals(Square, other.Square);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
                return false;
            if (ReferenceEquals(this, obj))
                return true;
            if (obj.GetType() != GetType())
                return false;
            return Equals((Emporium) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (Name != null ? Name.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Cashbox != null ? Cashbox.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Square != null ? Square.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Departments != null ? Departments.GetHashCode() : 0);
                return hashCode;
            }
        }
    }
}
