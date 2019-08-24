using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise._19
{
    public static class BmiCalculator
    {
        public static double Calculate(double heightInInches, double weightInPounds)
        {
            double bmi = (weightInPounds / (heightInInches * heightInInches)) * 703;
            return Math.Round(bmi, 2);
        }

        public static bool IsNormalWeightByBmi(double bmi)
        {
            return 18.50 <= bmi && bmi <= 25.00;
        }
    }
}
