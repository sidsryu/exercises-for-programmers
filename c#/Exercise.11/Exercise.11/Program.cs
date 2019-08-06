using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise._11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many Euros are you exchanging? ");
            string euro = Console.ReadLine();

            Console.Write("What is the exchange rate? ");
            string exchangeRateInEuro = Console.ReadLine();


            double e;
            double r;
            double.TryParse(euro, out e);
            double.TryParse(exchangeRateInEuro, out r);


            double dollar = Exchanger.EuroToDollar(e, r);

            Console.WriteLine($"{e} Euros at an exchange rate of {r} is");
            Console.WriteLine($"{dollar} dollars");

            Console.ReadKey();
        }
    }
}
