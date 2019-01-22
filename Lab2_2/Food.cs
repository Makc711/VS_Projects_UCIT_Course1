using System;

namespace Lab2_2
{
    [Serializable]
    public class Food : Product
    {
        public int ShelfLife { get; } // Срок годности, дней
        public DateTime DateOfManufacture { get; }
        public int ResidualShelfLife => ShelfLife - (DateTime.UtcNow.Date - DateOfManufacture.Date).Days;

        public Food(string name, int size, float markup, Department department, int shelfLife) : base(name, size, markup, department)
        {
            ShelfLife = shelfLife;
            DateOfManufacture = DateTime.UtcNow;
        }

        public override string ToString()
        {
            return $"{Name}; Количество: {Quantity}; Цена: {Pice}; Остаточный срок годности: {ResidualShelfLife} дней";
        }
    }
}
