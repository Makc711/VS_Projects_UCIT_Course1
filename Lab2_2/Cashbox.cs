using System;

namespace Lab2_2
{
    class Cashbox
    {
        public int StartupCapital { get; }
        public int Budget { get; private set; }
        public int Profit => Budget - StartupCapital;

        public Cashbox(int budget)
        {
            StartupCapital = budget;
            Budget = budget;
        }

        public void Buy(int cost)
        {
            if (cost <= Budget) 
            {
                Budget -= cost;
            } 
            else 
            {
                throw new ArgumentException($"Бюджет {Budget} меньше требуемых затрат {cost}");
            }
        }

        public void Sell(int cost)
        {
            Budget += cost;
        }

        public void ShowFinances()
        {
            Console.WriteLine($"Бюджет:  {Budget:0,0} руб.");
            Console.WriteLine($"Прибыль: {Profit:0,0} руб.");
        }
    }
}
