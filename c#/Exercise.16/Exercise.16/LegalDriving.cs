using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise._16
{
    public class LegalDriving
    {
        public static readonly int LegalAge = 16;

        public static bool IsLegalAge(int age)
        {
            return LegalAge <= age;
        }
    }
}
