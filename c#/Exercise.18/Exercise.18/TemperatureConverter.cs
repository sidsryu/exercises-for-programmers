using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise._18
{
    public static class TemperatureConverter
    {
        public static double FahrenheitToCelsius(double f)
        {
            double c = (f - 32.0) * (5.0 / 9.0);
            return Math.Round(c, 1);
        }

        public static double CelsiusToFahrenheit(double c)
        {
            double f = (c * (9.0 / 5.0)) + 32.0;
            return Math.Round(f, 1);
        }
    }
}
