using System;

namespace Lab2_2
{
    class Department : IEquatable<Department>
    {
        private Emporium _emporium;
        public int Area { get; private set; }
        public string Name { get; }

        public Emporium Emporium
        {
            set
            {
                if (_emporium == null)
                    _emporium = value;
            }
        }

        public Department(string name, int area)
        {
            Name = name;
            Area = area;
        }

        public void ExpandArea(int area)
        {
            _emporium.OccupyArea(area);
            Area += area;
        }

        public void ReduceArea(int area)
        {
            if (Area > area)
            {
                Area -= area;
                _emporium.ClearArea(area);
            }
            else
            {
                throw new ArgumentException($"В отделе не достаточно площади ({Area} <= {area})");
            }
        }

        public override string ToString()
        {
            return $"Отдел: {Name}; Площадь: {Area:0,0} м^2";
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
