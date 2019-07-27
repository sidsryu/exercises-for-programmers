using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise._5.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class StringFormulaTests
    {
        [Test]
        public void Add_Valid_ReturnFormula()
        {
            int first = 10;
            int second = 5;

            string formula = StringFormula.Add(first, second);

            Assert.That(formula, Is.EqualTo("10 + 5 = 15"));
        }

        [Test]
        public void Sub_Valid_ReturnFormula()
        {
            int first = 10;
            int second = 5;

            string formula = StringFormula.Sub(first, second);

            Assert.That(formula, Is.EqualTo("10 - 5 = 5"));
        }

        [Test]
        public void Mul_Valid_ReturnFormula()
        {
            int first = 10;
            int second = 5;

            string formula = StringFormula.Mul(first, second);

            Assert.That(formula, Is.EqualTo("10 * 5 = 50"));
        }

        [Test]
        public void Div_Valid_ReturnFormula()
        {
            int first = 10;
            int second = 5;

            string formula = StringFormula.Div(first, second);

            Assert.That(formula, Is.EqualTo("10 / 5 = 2"));
        }
    }
}
