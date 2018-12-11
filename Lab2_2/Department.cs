using System;
using System.Collections.Generic;

namespace Lab2_2
{
    class Department : IEquatable<Department>
    {
        private readonly Emporium _emporium;
        public string Name { get; }
        public int Area { get; private set; }
        public int FreeArea { get; private set; }
        public List<Product> Products { get; } = new List<Product>();

        public Department(string name, int area, Emporium emporium)
        {
            Name = name;
            Area = area;
            FreeArea = area;
            _emporium = emporium;
            emporium.AddDepartment(this);
            emporium.OccupyArea(area);
        }

        public void ExpandArea(int area)
        {
            _emporium.OccupyArea(area);
            Area += area;
            ClearArea(area);
        }

        public void ReduceArea(int area)
        {
            OccupyArea(area);
            Area -= area;
            _emporium.ClearArea(area);
        }

        public void OccupyArea(int area)
        {
            if (FreeArea >= area)
            {
                FreeArea -= area;
            }
            else
            {
                throw new ArgumentException($"В отделе не достаточно свободной площади ({FreeArea} < {area})");
            }
        }

        public void ClearArea(int area)
        {
            FreeArea += area;
        }

        public void AddProduct(Product product)
        {
            if (!Products.Contains(product))
            {
                Products.Add(product);
            }
            else
            {
                throw new ArgumentException($"Продукт {product.Name} уже существует");
            }
        }

        public Cashbox GetCashbox()
        {
            return _emporium.Cashbox;
        }

        public void ShowInformation()
        {
            Console.WriteLine(this);
            foreach (var product in Products)
            {
                Console.WriteLine("\t" + product);
            }
        }

        public override string ToString()
        {
            return $"Отдел: {Name}; Площадь: {(double)Area/10000:0,0.0} м^2; Свободная площадь: {(double)FreeArea /10000:0,0.0} м^2";
        }

        public bool Equals(Department other)
        {
            if (ReferenceEquals(null, other))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            return string.Equals(Name, other.Name);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
                return false;
            if (ReferenceEquals(this, obj))
                return true;
            if (obj.GetType() != GetType())
                return false;
            return Equals((Department) obj);
        }

        public override int GetHashCode() {
            return 397 ^ (Name != null ? Name.GetHashCode() : 0);
        }
    }
}
