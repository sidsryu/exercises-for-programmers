using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise._12.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class SimpleInterestTests
    {
        [Test]
        public void Calculate_PrincipalAndRateAndYears_ReturnTotalAmount()
        {
            double principal = 1500.00;
            double interestPercent = 4.3;
            int years = 4;

            double dollars = SimpleInterest.Calculate(principal, interestPercent, years);

            Assert.That(dollars, Is.EqualTo(1758.00));
        }

        [Test]
        public void Calculate_CentPrincipal_ReturnTotalAmountRoundCent()
        {
            double principal = 1500.50;
            double interestPercent = 4.3;
            int years = 4;

            double dollars = SimpleInterest.Calculate(principal, interestPercent, years);

            Assert.That(dollars, Is.EqualTo(1758.59));
        }
    }
}
