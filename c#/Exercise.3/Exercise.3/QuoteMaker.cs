using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise._3
{
    public static class QuoteMaker
    {
        public static string Make(string quoteText, string quoteeName)
        {
            if (string.IsNullOrEmpty(quoteText) || 
                string.IsNullOrEmpty(quoteeName))
            {
                return string.Empty;
            }
            else
            {
                return $"{quoteeName} says, \"{quoteText}\"";
            }
        }
    }
}
