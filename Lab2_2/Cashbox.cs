using System;

namespace Lab2_2
{
    class Cashbox
    {
        private int _budget;
        private int _profit;

        public Cashbox(int budget)
        {
            _budget = budget;
        }

        public void Buy(int cost)
        {
            if (cost <= _budget) 
            {
                _budget -= cost;
                _profit -= cost;
            } 
            else 
            {
                throw new ArgumentException($"Бюджет {_budget} меньше требуемых вложений {cost}");
            }
        }

        public void Sell(int cost)
        {
            _budget += cost;
            _profit += cost;
        }

        public void ShowFinances()
        {
            Console.WriteLine($"Бюджет:  {_budget:0,0} руб.");
            Console.WriteLine($"Прибыль: {_profit:0,0} руб.");
        }
    }
}
