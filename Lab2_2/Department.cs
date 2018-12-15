using System;
using System.Collections.Generic;

namespace Lab2_2
{
    class Department : IEquatable<Department>
    {
        public string Name { get; }
        public Square Square { get; }
        public Emporium Emporium { get; }
        public List<Product> Products { get; } = new List<Product>();

        public Department(string name, int area, Emporium emporium)
        {
            Name = name;
            Square = new Square(area);
            Emporium = emporium;
            Emporium.AddDepartment(this);
        }

        public Product this[int i] => Products[(i >= 0 && i < Products.Count) ? i : 0];

        public void ExpandArea(int area)
        {
            Emporium.Square.OccupyArea(area);
            Square.ExpandArea(area);
        }

        public void ReduceArea(int area)
        {
            Square.ReduceArea(area);
            Emporium.Square.VacateArea(area);
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

        public void RemoveProduct(Product product)
        {
            if (Products.Contains(product))
            {
                Square.VacateArea(product.Size);
                Products.Remove(product);
            }
            else
            {
                throw new ArgumentException($"В отделе нет продукта {product.Name}");
            }
        }

        public void BuyProduct(Product product, int quantity, int price)
        {
            Emporium.Cashbox.Buy(quantity * price);
            Square.OccupyArea(quantity * product.Size);
            product.Quantity += quantity;
            product.Pice = (int)(price * product.Markup);
        }

        public void SellProduct(Product product, int quantity)
        {
            if (product.Quantity >= quantity)
            {
                product.Quantity -= quantity;
                Emporium.Cashbox.Sell(quantity * product.Pice);
                Square.VacateArea(quantity * product.Size);
            }
            else
            {
                throw new ArgumentException($"Продукт {Name} закончился ({product.Quantity} < {quantity})");
            }
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
            return $"Отдел: {Name}; Площадь: {(double)Square.Area /10000:0,0.0} м^2; Свободная площадь: {(double)Square.FreeArea /10000:0,0.0} м^2";
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
