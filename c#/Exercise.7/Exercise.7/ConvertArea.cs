using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise._7
{
    public static class ConvertArea
    {
        public static double SquareFeetToSquareMeterRatio { get; } = 0.09290304;

        public static double SquareFeetToSquareMeter(double sqft)
        {
            return sqft * SquareFeetToSquareMeterRatio;
        }
    }
}
