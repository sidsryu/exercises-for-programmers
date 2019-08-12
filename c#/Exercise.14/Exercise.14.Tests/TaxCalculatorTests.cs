using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise._14.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class TaxCalculatorTests
    {
        [Test]
        public void Calculate_AmountAndWisconsin_ReturnTaxAndTotal()
        {
            double amount = 10.00;
            string state = "WI";

            var result = TaxCalculator.Calculate(amount, state);

            Assert.That(result, Is.EqualTo((0.55, 10.55)));
        }

        [Test]
        public void Calculate_CentAmountAndWisconsin_ReturnTaxAndRoundUpTotal()
        {
            double amount = 10.05;
            string state = "WI";

            var result = TaxCalculator.Calculate(amount, state);

            Assert.That(result, Is.EqualTo((0.55, 10.60)).Within(0.001));
        }

        [Test]
        public void Calculate_AmountAndNotWisconsin_ReturnTaxFreeTotal()
        {
            double amount = 10.00;
            string state = "MN";

            var result = TaxCalculator.Calculate(amount, state);

            Assert.That(result, Is.EqualTo((0.00, 10.00)));
        }
    }
}
