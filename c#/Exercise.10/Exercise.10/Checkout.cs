using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise._10
{
    public class Checkout
    {
        private double TaxRate { get; } = 0.055;
        private List<OrderItem> orders = new List<OrderItem>();

        public void AddOrder(OrderItem item)
        {
            orders.Add(item);
        }

        public double Subtotal()
        {
            return orders.Sum(o => o.Price * o.Count);
        }

        public double Tax()
        {
            return Subtotal() * TaxRate;
        }

        public double Total()
        {
            return Subtotal() + Tax();
        }
    }
}
