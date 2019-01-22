using System;

namespace Lab2_2
{
    [Serializable]
    public class Cashbox : IEquatable<Cashbox>
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

        public bool Equals(Cashbox other)
        {
            if (ReferenceEquals(null, other))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            return StartupCapital == other.StartupCapital && 
                Budget == other.Budget;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
                return false;
            if (ReferenceEquals(this, obj))
                return true;
            if (obj.GetType() != GetType())
                return false;
            return Equals((Cashbox) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (StartupCapital * 397) ^ Profit;
            }
        }
    }
}
