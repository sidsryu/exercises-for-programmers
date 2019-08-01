using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise._10.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class CheckoutTests
    {
        [Test]
        public void Subtotal_Orders_ReturnSubtotal()
        {
            var checkout = new Checkout();
            checkout.AddOrder(new OrderItem(25.00, 2));
            checkout.AddOrder(new OrderItem(10.00, 1));
            checkout.AddOrder(new OrderItem(4.00, 1));

            double subtotal = checkout.Subtotal();

            Assert.That(subtotal, Is.EqualTo(64.00).Within(0.01));
        }

        [Test]
        public void Tax_Orders_ReturnTax()
        {
            var checkout = new Checkout();
            checkout.AddOrder(new OrderItem(25.00, 2));
            checkout.AddOrder(new OrderItem(10.00, 1));
            checkout.AddOrder(new OrderItem(4.00, 1));

            double tax = checkout.Tax();

            Assert.That(tax, Is.EqualTo(3.52).Within(0.01));
        }

        [Test]
        public void Total_Orders_ReturnTotalAppliedTax()
        {
            var checkout = new Checkout();
            checkout.AddOrder(new OrderItem(25.00, 2));
            checkout.AddOrder(new OrderItem(10.00, 1));
            checkout.AddOrder(new OrderItem(4.00, 1));

            double total = checkout.Total();

            Assert.That(total, Is.EqualTo(67.52).Within(0.01));
        }
    }
}
