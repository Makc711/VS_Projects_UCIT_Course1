using System;

namespace Lab2_2
{
    abstract class Square
    {
        public int Area { get; protected internal set; } // Площадь, см^2
        public int FreeArea { get; protected internal set; }

        public virtual void ExpandArea(int area)
        {
            Area += area;
            ClearArea(area);
        }

        public virtual void ReduceArea(int area)
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
                throw new ArgumentException($"Не достаточно свободной площади ({FreeArea} < {area})");
            }
        }

        public void ClearArea(int area)
        {
            FreeArea += area;
        }
    }
}
