using System;

namespace Lab2_2
{
    [Serializable]
    public class Square : IEquatable<Square>
    {
        public int Area { get; private set; } // Полная площадь, см^2
        public int FreeArea { get; private set; } // Свободная площадь, см^2

        public Square(int area)
        {
            Area = area;
            FreeArea = area;
        }

        public void ExpandArea(int area)
        {
            Area += area;
            VacateArea(area);
        }

        public void ReduceArea(int area)
        {
            OccupyArea(area);
            Area -= area;
        }

        public void OccupyArea(int area)
        {
            if (FreeArea >= area)
            {
                FreeArea -= area;
            }
            else
            {
                throw new ArgumentException($"Не достаточно свободной площади ({FreeArea / 10_000} < {area / 10_000})");
            }
        }

        public void VacateArea(int area)
        {
            if (Area >= FreeArea + area)
            {
                FreeArea += area;
            }
            else
            {
                throw new ArgumentException($"Не достаточно полной площади ({Area / 10_000} < {(FreeArea + area) / 10_000})");
            }
        }

        public bool Equals(Square other)
        {
            if (ReferenceEquals(null, other))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            return Area == other.Area && 
                FreeArea == other.FreeArea;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
                return false;
            if (ReferenceEquals(this, obj))
                return true;
            if (obj.GetType() != GetType())
                return false;
            return Equals((Square) obj);
        }

        public override int GetHashCode()
        {
            return 397;
        }
    }
}
