using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise._5
{
    public static class PairConverter
    {
        public static (int, int) ToInt(string first, string second)
        {
            int f;
            int s;

            // Result is zero when fail.
            int.TryParse(first, out f);
            int.TryParse(second, out s);

            return (f, s);
        }
    }
}
