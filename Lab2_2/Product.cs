using System;

namespace Lab2_2
{
    [Serializable]
    public class Product : IEquatable<Product>
    {
        public string Name { get; }
        public int Quantity { get; set; }
        public int Size { get; } // Занимаемая площадь одним продуктом, см^2
        public float Markup { get; } // Наценка (150% = 1,5)
        public int Pice { get; set; }
        public Department Department { get; }

        public Product(string name, int size, float markup, Department department)
        {
            Name = name;
            Size = size;
            Markup = markup;
            Department = department;
            try
            {
                Department.AddProduct(this);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public override string ToString()
        {
            return $"{Name}; Количество: {Quantity}; Цена: {Pice}";
        }

        public bool Equals(Product other)
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
            return Equals((Product)obj);
        }

        public override int GetHashCode()
        {
            return 397 ^ (Name != null ? Name.GetHashCode() : 0);
        }
    }
}
