using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise._11
{
    public static class Exchanger
    {
        public static double ExchangeRateInDollar { get; } = 100.0;

        public static double EuroToDollar(double euro, double exchangeRateInEuro)
        {
            double dollar = euro* exchangeRateInEuro / ExchangeRateInDollar;
            return Math.Round(dollar, 2);
        }
    }
}
