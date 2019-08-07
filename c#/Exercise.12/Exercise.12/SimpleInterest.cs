using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise._12
{
    public static class SimpleInterest
    {
        public static double Calculate(double principal, double interestPercent, int years)
        {
            double interestDecimal = interestPercent / 100.0;
            double total = principal * (1.0 + (interestDecimal * years));
            return Math.Round(total, 2);
        }
    }
}
