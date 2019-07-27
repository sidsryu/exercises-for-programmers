using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise._5.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class PairConverterTests
    {
        [Test]
        public void ToInt_Valid_ReturnIntTuple()
        {
            string first = "10";
            string second = "5";

            var result = PairConverter.ToInt(first, second);

            Assert.That(result, Is.EqualTo((10, 5)));
        }

        [Test]
        public void ToInt_EmptyFirst_ReturnZeroInstead()
        {
            string first = string.Empty;
            string second = "5";

            var result = PairConverter.ToInt(first, second);

            Assert.That(result, Is.EqualTo((0, 5)));
        }

        [Test]
        public void ToInt_NullFirst_ReturnZeroInstead()
        {
            string first = null;
            string second = "5";

            var result = PairConverter.ToInt(first, second);

            Assert.That(result, Is.EqualTo((0, 5)));
        }

        [Test]
        public void ToInt_EmptySecond_ReturnZeroInstead()
        {
            string first = "10";
            string second = string.Empty;

            var result = PairConverter.ToInt(first, second);

            Assert.That(result, Is.EqualTo((10, 0)));
        }

        [Test]
        public void ToInt_NullSecond_ReturnZeroInstead()
        {
            string first = "10";
            string second = null;

            var result = PairConverter.ToInt(first, second);

            Assert.That(result, Is.EqualTo((10, 0)));
        }
    }
}
