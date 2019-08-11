using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise._13.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class CompoundInterestTests
    {
        [Test]
        public void Calculate_PrincipalAndPercentageAndYearsAndPeriods_ReturnTotalAmount()
        {
            var context = new CompoundInterestContext
            {
                Principal = 1500.00,
                InterestPercent = 4.3,
                InvestYears = 6,
                CompoundingFrequency = 4,
            };

            double sum = CompoundInterest.Calculate(context);

            Assert.That(sum, Is.EqualTo(1938.84));
        }
    }
}
