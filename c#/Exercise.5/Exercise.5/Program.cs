using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is the first number? ");
            string first = Console.ReadLine();

            Console.Write("What is the second number? ");
            string second = Console.ReadLine();

            var (f, s) = PairConverter.ToInt(first, second);

            string add = StringFormula.Add(f, s);
            Console.WriteLine(add);

            string sub = StringFormula.Sub(f, s);
            Console.WriteLine(sub);

            string mul = StringFormula.Mul(f, s);
            Console.WriteLine(mul);

            string div = StringFormula.Div(f, s);
            Console.WriteLine(div);
        }
    }
}
