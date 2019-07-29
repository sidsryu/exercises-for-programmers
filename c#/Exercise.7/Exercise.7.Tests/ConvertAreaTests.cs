using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise._7.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class ConvertAreaTests
    {
        [Test]
        public void SquareFeetToSquareMeter_SquareFeet_ReturnSquareMeter()
        {
            double sqft = 300;
            double sqm = ConvertArea.SquareFeetToSquareMeter(sqft);

            Assert.That(sqm, Is.EqualTo(27.8709).Within(0.0001));
        }

        [Test]
        public void SquareFeetToSquareMeter_LessSquareFeet_ReturnSquareMeter()
        {
            double sqft = 0.1;
            double sqm = ConvertArea.SquareFeetToSquareMeter(sqft);

            Assert.That(sqm, Is.EqualTo(0.0092).Within(0.0001));
        }

        [Test]
        public void SquareFeetToSquareMeter_LargeSquareFeet_ReturnSquareMeter()
        {
            double sqft = 10000;
            double sqm = ConvertArea.SquareFeetToSquareMeter(sqft);

            Assert.That(sqm, Is.EqualTo(929.0304).Within(0.0001));
        }
    }
}
