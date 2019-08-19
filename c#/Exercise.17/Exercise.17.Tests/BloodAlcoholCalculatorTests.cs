using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise._17.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class BloodAlcoholCalculatorTests
    {
        [Test]
        public void CalcBac_LimitContext_ReturnBacLimit()
        {
            var ctx = new BloodAlcoholContext()
            {
                AlcoholConsumedOz = 5.0,
                BodyWeightLb = 190.0,
                TargetSex = BloodAlcoholContext.Sex.Male,
                HoursSinceTheLastDrink = 1.0,
            };

            double bac = BloodAlcoholCalculator.CalcBac(ctx);

            Assert.That(bac, Is.EqualTo(0.08).Within(0.001));
        }

        [Test]
        public void IsLegalDrive_ModerateDrinking_ReturnTrue()
        {
            double bac = 0.07;

            bool result = BloodAlcoholCalculator.IsLegalDrive(bac);

            Assert.That(result, Is.True);
        }

        [Test]
        public void IsLegalDrive_BingeDrinking_ReturnFalse()
        {
            double bac = 0.08;

            bool result = BloodAlcoholCalculator.IsLegalDrive(bac);

            Assert.That(result, Is.False);
        }
    }
}
