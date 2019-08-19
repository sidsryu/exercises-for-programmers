using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise._17
{
    public static class BloodAlcoholCalculator
    {
        public static readonly double LegalBacLimit = 0.08;

        public static double CalcBac(BloodAlcoholContext ctx)
        {
            double a = ctx.AlcoholConsumedOz;
            double w = ctx.BodyWeightLb;
            double h = ctx.HoursSinceTheLastDrink;
            double r = ctx.TargetSex == BloodAlcoholContext.Sex.Male ? 0.73 : 0.66;

            double bac = (a * 5.14 / w * r) - (0.015 * h);
            return Math.Round(bac, 2);
        }

        public static bool IsLegalDrive(double bac)
        {
            return bac < LegalBacLimit;
        }
    }
}
