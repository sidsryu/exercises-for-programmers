using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise._6
{
    public class RetireReporter
    {
        private INowYear nowYear = new DefaultNowYear();

        public RetireReporter()
        { }

        public RetireReporter(INowYear nowYear)
        {
            this.nowYear = nowYear;
        }

        public string Report(int leftRetireYears)
        {
            if (leftRetireYears < 0)
            {
                return string.Empty;
            }
            else
            {
                return
                    $"You have {leftRetireYears} years left until you can retire.\n" +
                    $"It's {nowYear.Now}, so you can retire " +
                    $"in {nowYear.Now + leftRetireYears}.";
            }
        }
    }
}
