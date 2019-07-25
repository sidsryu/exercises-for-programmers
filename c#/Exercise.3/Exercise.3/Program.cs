using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is the quote? ");
            string quoteText = Console.ReadLine();

            Console.Write("Who said it? ");
            string quoteeName = Console.ReadLine();

            string result = QuoteMaker.Make(quoteText, quoteeName);
            Console.WriteLine(result);
        }
    }
}
