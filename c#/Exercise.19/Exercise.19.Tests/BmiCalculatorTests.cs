using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise._19.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class BmiCalculatorTests
    {
        [Test]
        public void Calculate_NormalWeightSmallBody_Return18Point8()
        {
            double heightInInches = 58.00;
            double weightInPounds = 90.00;
            
            double bmi = BmiCalculator.Calculate(heightInInches, weightInPounds);

            Assert.That(bmi, Is.EqualTo(18.80).Within(0.01));
        }

        [Test]
        public void Calculate_NormalWeightBigBody_Return23Point46()
        {
            double heightInInches = 83.00;
            double weightInPounds = 230.00;

            double bmi = BmiCalculator.Calculate(heightInInches, weightInPounds);

            Assert.That(bmi, Is.EqualTo(23.46).Within(0.01));
        }

        [Test]
        public void IsNormalWeightByBmi_MinimumNormal_ReturnTrue()
        {
            double bmi = 18.50;

            bool result = BmiCalculator.IsNormalWeightByBmi(bmi);

            Assert.That(result, Is.True);
        }

        [Test]
        public void IsNormalWeightByBmi_Underweight_ReturnFalse()
        {
            double bmi = 18.49;

            bool result = BmiCalculator.IsNormalWeightByBmi(bmi);

            Assert.That(result, Is.False);
        }

        [Test]
        public void IsNormalWeightByBmi_MaximumNormal_ReturnTrue()
        {
            double bmi = 25.00;

            bool result = BmiCalculator.IsNormalWeightByBmi(bmi);

            Assert.That(result, Is.True);
        }

        [Test]
        public void IsNormalWeightByBmi_Overweight_ReturnFalse()
        {
            double bmi = 25.01;

            bool result = BmiCalculator.IsNormalWeightByBmi(bmi);

            Assert.That(result, Is.False);
        }
    }
}
