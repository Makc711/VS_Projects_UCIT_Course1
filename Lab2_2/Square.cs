using System;

namespace Lab2_2
{
    class Square
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
                throw new ArgumentException($"Не достаточно свободной площади ({FreeArea} < {area})");
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
                throw new ArgumentException($"Не достаточно полной площади ({Area} < {FreeArea + area})");
            }
        }
    }
}
