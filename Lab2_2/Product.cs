using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_2
{
    class Product
    {
        private readonly Department _department;
        private int _quantity;
        private float _size; // Занимаемая площадь одним продуктом, м^2
        private readonly float _markup; // Наценка (150% = 1,5)
        private int _pice;
        private readonly Cashbox _cashbox;
        public string Name { get; }

        public Product(string name, float size, float markup, Department department)
        {
            Name = name;
            _size = size;
            _markup = markup;
            _department = department;
            _cashbox = department.GetCashbox();
        }

        public void Buy(int quantity, int price)
        {
            _cashbox.Buy(quantity * price);
            _quantity += quantity;
            _pice = (int) (price * _markup);
        }

        public void Sell(int quantity)
        {
            _cashbox.Sell(quantity * _pice);
        }
    }
}
