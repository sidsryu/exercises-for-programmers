using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise._13
{
    public struct CompoundInterestContext
    {
        public double Principal { get; set; }
        public double InterestPercent { get; set; }
        public int InvestYears { get; set; }
        public int CompoundingFrequency { get; set; }
    }
}
