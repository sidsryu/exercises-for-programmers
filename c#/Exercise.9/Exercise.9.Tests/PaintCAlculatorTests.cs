using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise._9.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class PaintCalculatorTests
    {
        [Test]
        public void Calculate_SquareMeter_ReturnLiters()
        {
            int squareMeter = 10;
            int liters = PaintCalculator.Calculate(squareMeter);

            Assert.That(liters, Is.EqualTo(2));
        }
    }
}
