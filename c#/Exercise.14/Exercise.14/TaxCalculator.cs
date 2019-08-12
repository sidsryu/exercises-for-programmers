using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise._14
{
    public static class TaxCalculator
    {
        public static (double, double) Calculate(double amount, string state)
        {
            if (state == "WI")
            {
                double taxRate = 0.055;
                double charged = Math.Round(amount * taxRate, 2);

                return (charged, amount + charged);
            }

            return (0.00, amount);
        }
    }
}
