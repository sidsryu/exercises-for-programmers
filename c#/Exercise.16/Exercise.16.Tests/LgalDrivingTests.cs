using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise._16.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class LegalDrivingTests
    {
        [Test]
        public void IsLegalAge_Sixteen_ReturnTrue()
        {
            int age = 16;

            bool result = LegalDriving.IsLegalAge(age);

            Assert.That(result, Is.True);
        }

        [Test]
        public void IsLegalAge_OlderThanSixteen_ReturTrue()
        {
            int age = 35;

            bool result = LegalDriving.IsLegalAge(age);

            Assert.That(result, Is.True);
        }

        [Test]
        public void IsLegalAge_YoungerThanSixteen_ReturnFalse()
        {
            int age = 15;

            bool result = LegalDriving.IsLegalAge(age);

            Assert.That(result, Is.False);
        }
    }
}
