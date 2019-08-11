using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise._13
{
    public static class CompoundInterest
    {
        public static double Calculate(CompoundInterestContext context)
        {
            double p = context.Principal;
            double r = context.InterestPercent / 100.0;
            int n = context.CompoundingFrequency;
            int t = context.InvestYears;

            double sum = p * Math.Pow(1 + r / n, n * t);
            return Math.Round(sum, 2);
        }
    }
}
