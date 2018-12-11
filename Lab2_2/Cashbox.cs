using System;

namespace Lab2_2
{
    class Cashbox
    {
        public int Budget { get; private set; }
        public int Profit { get; private set; }

        public Cashbox(int budget)
        {
            Budget = budget;
        }

        public void Buy(int cost)
        {
            if (cost <= Budget) 
            {
                Budget -= cost;
                Profit -= cost;
            } 
            else 
            {
                throw new ArgumentException($"Бюджет {Budget} меньше требуемых вложений {cost}");
            }
        }

        public void Sell(int cost)
        {
            Budget += cost;
            Profit += cost;
        }

        public void ShowFinances()
        {
            Console.WriteLine($"Бюджет:  {Budget:0,0} руб.");
            Console.WriteLine($"Прибыль: {Profit:0,0} руб.");
        }
    }
}
