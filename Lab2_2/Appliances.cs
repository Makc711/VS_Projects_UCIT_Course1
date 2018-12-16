namespace Lab2_2
{
    class Appliances : Product
    {
        public int WarrantyPeriod { get; } // Гарантия, мес.

        public Appliances(string name, int size, float markup, Department department, int warrantyPeriod) : base(name, size, markup, department)
        {
            WarrantyPeriod = warrantyPeriod;
        }

        public override string ToString()
        {
            return $"{Name}; Количество: {Quantity}; Цена: {Pice}; Гарантия: {WarrantyPeriod} мес.";
        }
    }
}
