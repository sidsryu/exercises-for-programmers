using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise._17
{
    public struct BloodAlcoholContext
    {
        public enum Sex
        {
            Male,
            Female,
        };

        public double AlcoholConsumedOz { get; set; }
        public double BodyWeightLb { get; set; }
        public Sex TargetSex { get; set; }
        public double HoursSinceTheLastDrink { get; set; }
    }
}
