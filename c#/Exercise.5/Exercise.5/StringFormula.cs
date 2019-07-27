using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise._5
{
    public class StringFormula
    {
        public static string Add(int first, int second)
        {
            return $"{first} + {second} = {first + second}";
        }

        public static string Sub(int first, int second)
        {
            return $"{first} - {second} = {first - second}";
        }

        public static string Mul(int first, int second)
        {
            return $"{first} * {second} = {first * second}";
        }

        public static string Div(int first, int second)
        {
            return $"{first} / {second} = {first / second}";
        }
    }
}
