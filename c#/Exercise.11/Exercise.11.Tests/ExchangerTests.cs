using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise._11.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class ExchangerTests
    {
        [Test]
        public void EuroToDollar_EuroAndExchangeRate_ReturnDollar()
        {
            double euro = 81;
            double exchangeRateInEuro = 137.51;

            double dollar = Exchanger.EuroToDollar(euro, exchangeRateInEuro);

            Assert.That(dollar, Is.EqualTo(111.38));
        } 
    }
}
