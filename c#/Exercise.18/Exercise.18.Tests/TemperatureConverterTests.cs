using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise._18.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class TemperatureConverterTests
    {
        [TestCase(0.0, -17.8)]
        [TestCase(98.6, 37.0)]
        [TestCase(100.0, 37.8)]
        public void FahrenheitToCelsiusTests(double f, double expected)
        {
            double c = TemperatureConverter.FahrenheitToCelsius(f);

            Assert.That(c, Is.EqualTo(expected));
        }

        [TestCase(0.0, 32.0)]
        [TestCase(37.0, 98.6)]
        [TestCase(100.0, 212.0)]
        public void CelsiusToFahrenheitTests(double c, double expected)
        {
            double f = TemperatureConverter.CelsiusToFahrenheit(c);

            Assert.That(f, Is.EqualTo(expected));
        }
    }
}
