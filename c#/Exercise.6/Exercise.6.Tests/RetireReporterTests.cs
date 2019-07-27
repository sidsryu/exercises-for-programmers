using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise._6.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class RetireReporterTests
    {
        [Test]
        public void Report_RemainRetireYears_ReturnMessageIncludeYear()
        {
            StubNowYear nowYear = new StubNowYear();
            nowYear.Now = 2015;

            RetireReporter reporter = new RetireReporter(nowYear);
            string result = reporter.Report(40);

            string expected = "You have 40 years left until you can retire.\n" +
                "It's 2015, so you can retire in 2055.";
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Report_NegativeYears_ReturnEmptyString()
        {
            RetireReporter reporter = new RetireReporter();
            string result = reporter.Report(-1);

            Assert.That(result, Is.Empty);
        }

        internal class StubNowYear : INowYear
        {
            public int Now { get; set; }
        }
    }
}
