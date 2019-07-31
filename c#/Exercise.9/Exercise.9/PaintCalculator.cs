using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise._9
{
    public static class PaintCalculator
    {
        public static int FillSquareMeterUnit { get; } = 9;

        public static int Calculate(int squareMeter)
        {
            double liters = (double)squareMeter / FillSquareMeterUnit;
            return (int)Math.Ceiling(liters);
        }
    }
}
