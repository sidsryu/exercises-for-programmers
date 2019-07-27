using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise._6
{
    public struct DefaultNowYear : INowYear
    {
        private static readonly DateTime now = DateTime.Now;

        public int Now
        {
            get
            {
                return now.Year;
            }

            set { }
        }
    }
}
