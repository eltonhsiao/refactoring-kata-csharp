using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace RefactoringKata
{
    public class Orders
    {
        private List<Order> _orders = new List<Order>();

        public void AddOrder(Order order)
        {
            _orders.Add(order);
        }

        public int GetOrdersCount()
        {
            return _orders.Count;
        }

        public Order GetOrder(int i)
        {
            return _orders[i];
        }

        public string FormatString()
        {
            string outputString = string.Empty;
            foreach (var i in _orders)
            {
                outputString += i.FormatString();
            }

            if (_orders.Count > 0)
            {
                outputString = outputString.Remove(outputString.Length - 2, 2);
            }

            return string.Format("{{\"orders\": [{0}]}}", string.Join(", ", outputString));
        }
    }
}
