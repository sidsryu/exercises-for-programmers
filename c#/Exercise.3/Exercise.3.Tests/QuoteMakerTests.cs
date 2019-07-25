using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise._3.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class QuoteMakerTests
    {
        [Test]
        public void Make_Valid_ReturnQuotedString()
        {
            string quoteText = "These aren't the droids you're looking for.";
            string quoteeName = "Obi-Wan Kenobi";
            string result = QuoteMaker.Make(quoteText, quoteeName);

            Assert.That(result, Is.EqualTo("Obi-Wan Kenobi says, \"These aren't the droids you're looking for.\""));
        }

        [Test]
        public void Make_AnotherValid_ReturnQuotedString()
        {
            string quoteText = "Knowledge is power.";
            string quoteeName = "Francis Bacon";
            string result = QuoteMaker.Make(quoteText, quoteeName);

            Assert.That(result, Is.EqualTo("Francis Bacon says, \"Knowledge is power.\""));
        }

        [Test]
        public void Make_EmptyQuoteText_ReturnEmptyString()
        {
            string result = QuoteMaker.Make(string.Empty, "Francis Bacon");

            Assert.That(result, Is.Empty);
        }

        [Test]
        public void Make_EmptyQuoteeName_ReturnEmptyString()
        {
            string result = QuoteMaker.Make("Knowledge is power.", string.Empty);

            Assert.That(result, Is.Empty);
        }
    }
}
